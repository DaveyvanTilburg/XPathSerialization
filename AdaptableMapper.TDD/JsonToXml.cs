﻿using FluentAssertions;
using System.Collections.Generic;
using System.Xml.Linq;
using AdaptableMapper.Configuration;
using Xunit;

namespace AdaptableMapper.TDD
{
    public class JsonToXml
    {
        [Fact]
        public void JsonToXmlTest()
        {
            var errorObserver = new TestErrorObserver();
            Process.ProcessObservable.GetInstance().Register(errorObserver);

            MappingConfiguration mappingConfiguration = GetMappingConfiguration();

            XElement result = mappingConfiguration.Map(System.IO.File.ReadAllText(@".\Resources\JsonSource_HardwareComposition.json"), System.IO.File.ReadAllText(@".\Resources\XmlTarget_HardwareTemplate.xml")) as XElement;

            Process.ProcessObservable.GetInstance().Unregister(errorObserver);

            string expectedResult = System.IO.File.ReadAllText(@".\Resources\XmlTarget_HardwareExpected.xml");
            XElement xExpectedResult = XElement.Parse(expectedResult);

            errorObserver.GetRaisedWarnings().Count.Should().Be(0);
            errorObserver.GetRaisedErrors().Count.Should().Be(0);
            errorObserver.GetRaisedOtherTypes().Count.Should().Be(0);

            result.Should().BeEquivalentTo(xExpectedResult);
        }

        private static MappingConfiguration GetMappingConfiguration()
        {
            var cpuCores = new Mapping(
                new Traversals.Json.JsonGetValueTraversal(".CPU[0].Cores"),
                new Xml.XmlSetValueTraversal("./cpu/@cores")
            );

            var cpuSpeed = new Mapping(
                new Traversals.Json.JsonGetValueTraversal(".CPU[0].Speed"),
                new Xml.XmlSetValueTraversal("./cpu/@speed")
            );

            var graphicalCardScope = new MappingScopeComposite(
                new List<MappingScopeComposite>(),
                new List<Mapping>
                {
                    cpuCores,
                    cpuSpeed
                },
                new Traversals.Json.JsonGetScopeTraversal(".GraphicalCard[*]"),
                new Xml.XmlGetTemplateTraversal("./graphicalCard"),
                new Xml.XmlChildCreator()
            );

            var motherboardBrand = new Mapping(
                new Traversals.Json.JsonGetValueTraversal(".Brand"),
                new Xml.XmlSetValueTraversal("./@motherboardBrand")
            );
            var motherboardCpuBrand = new Mapping(
                new Traversals.Json.JsonGetValueTraversal(".CPU[0].Brand"),
                new Xml.XmlSetValueTraversal("./@cpuBrand")
            );
            var motherboardTotalStorage = new Mapping(
                new Traversals.Json.JsonGetValueTraversal(".HardDrive[0].Size"),
                new Xml.XmlSetValueTraversal("./@storage")
            );
            var motherboardPartner = new Mapping(
                new Traversals.Json.JsonGetSearchValueTraversal(
                    "../../../../../.Brand[?(@.Name=='{{searchValue}}')].Partner",
                    ".Brand"),
                new Xml.XmlSetValueTraversal("./@brandPartner")
            );

            var motherboardScope = new MappingScopeComposite(
                new List<MappingScopeComposite>
                {
                    graphicalCardScope
                },
                new List<Mapping>
                {
                    motherboardBrand,
                    motherboardCpuBrand,
                    motherboardTotalStorage,
                    motherboardPartner
                },
                new Traversals.Json.JsonGetScopeTraversal("$.Computer.Motherboard[*]"),
                new Xml.XmlGetTemplateTraversal("//computers/computer"),
                new Xml.XmlChildCreator()
            );

            var memorySize = new Mapping(
                new Traversals.Json.JsonGetValueTraversal("$.Size"),
                new Xml.XmlSetValueTraversal("./@size")
            );

            var memoryBrand = new Mapping(
                new Traversals.Json.JsonGetValueTraversal("../../../.Brand"),
                new Xml.XmlSetValueTraversal("./@brand")
            );

            var memoryMotherboardBrand = new Mapping(
                new Traversals.Json.JsonGetValueTraversal("../../../../../../.Brand"),
                new Xml.XmlSetValueTraversal("./@onMotherboardWithBrand")
            );

            var memoriesScope = new MappingScopeComposite(
                new List<MappingScopeComposite>(),
                new List<Mapping>
                {
                    memorySize,
                    memoryBrand,
                    memoryMotherboardBrand
                },
                new Traversals.Json.JsonGetScopeTraversal("$.Computer.Motherboard[*].Memory[*].MemoryChip[*]"),
                new Xml.XmlGetTemplateTraversal("//allMemories/memory"),
                new Xml.XmlChildCreator()
            );

            var scopes = new List<MappingScopeComposite>
            {
                memoriesScope,
                motherboardScope
            };

            var mappingConfiguration = new MappingConfiguration(
                scopes,
                new ContextFactory(
                    new Configuration.Json.JsonObjectConverter(),
                    new Xml.XmlTargetInstantiator()
                ),
                new NullObjectConverter()
            );

            return mappingConfiguration;
        }
    }
}