﻿using AdaptableMapper.Traversals;
using System.Collections.Generic;
using AdaptableMapper.Conditions;

namespace AdaptableMapper.Configuration
{
    public sealed class MappingScopeComposite
    {
        public List<MappingScopeComposite> MappingScopeComposites { get; set; }
        public List<Mapping> Mappings { get; set; }

        public GetScopeTraversal GetScopeTraversal { get; set; }
        public Condition Condition { get; set; }

        public GetTemplateTraversal GetTemplateTraversal { get; set; }
        public ChildCreator ChildCreator { get; set; }

        public MappingScopeComposite(
            List<MappingScopeComposite> mappingScopeComposites,
            List<Mapping> mappings,
            GetScopeTraversal getScopeTraversal,
            GetTemplateTraversal getTemplateTraversal,
            ChildCreator childCreator)
        {
            MappingScopeComposites = mappingScopeComposites;
            Mappings = mappings;
            GetScopeTraversal = getScopeTraversal;
            GetTemplateTraversal = getTemplateTraversal;
            ChildCreator = childCreator;
        }

        public void Traverse(Context context, TemplateCache templateCache)
        {
            if (!Validate())
                return;

            IEnumerable<object> scope = GetScopeTraversal.GetScope(context.Source);

            Template template = GetTemplateTraversal.GetTemplate(context.Target, templateCache);

            foreach (object item in scope)
            {
                object newChild = ChildCreator.CreateChild(template);
                Context childContext = new Context(source: item, target: newChild);

                if (Condition != null && !Condition.Validate(childContext))
                    continue;

                ChildCreator.AddToParent(template, newChild);
                TraverseChild(childContext, templateCache);
            }
        }

        private bool Validate()
        {
            bool result = true;

            if (GetScopeTraversal == null)
            {
                Process.ProcessObservable.GetInstance().Raise("TREE#7; GetScopeTraversal cannot be null", "error");
                result = false;
            }

            if (GetTemplateTraversal == null)
            {
                Process.ProcessObservable.GetInstance().Raise("TREE#9; Get cannot be null", "error");
                result = false;
            }

            if (ChildCreator == null)
            {
                Process.ProcessObservable.GetInstance().Raise("TREE#10; ChildCreator cannot be null", "error");
                result = false;
            }

            return result;
        }

        private void TraverseChild(Context context, TemplateCache templateCache)
        {
            foreach (Mapping mapping in Mappings)
                mapping.Map(context);

            foreach (MappingScopeComposite mappingScopeComposite in MappingScopeComposites)
                mappingScopeComposite.Traverse(context, templateCache);
        }
    }
}