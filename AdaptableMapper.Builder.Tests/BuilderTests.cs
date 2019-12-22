﻿using System.IO;
using AdaptableMapper.Configuration.Json;
using AdaptableMapper.Configuration.Xml;
using FluentAssertions;
using Xunit;

namespace AdaptableMapper.Builder.Tests
{
    public class BuilderTests
    {
        [Fact]
        public void Test()
        {
            string[] commands = File.ReadAllLines("./Resources/Mapping1.txt");

            var subject = new Builder();

            MappingConfiguration result = subject.Build(commands);
            result.Should().NotBeNull();
            result.ResultObjectConverter.Should().BeOfType(typeof(XElementToStringObjectConverter));

            result.ContextFactory.Should().NotBeNull();
            result.ContextFactory.ObjectConverter.Should().BeOfType(typeof(XmlObjectConverter));
            result.ContextFactory.TargetInstantiator.Should().BeOfType(typeof(JsonTargetInstantiator));
        }
    }
}