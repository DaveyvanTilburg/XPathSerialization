﻿using FluentAssertions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;
using AdaptableMapper;
using Xunit;
using AdaptableMapper.Traversals;

namespace AdaptableMapper.TDD
{
    public class XPathTester
    {
        [Fact]
        public void Serialize()
        {
            var errorObserver = new TestErrorObserver();
            Errors.ErrorObservable.GetInstance().Register(errorObserver);

            var config = GetFakedSerializationConfiguration();
            object resultObject = Mapper.Map(config, System.IO.File.ReadAllText(@".\Xmls\BOO_Reservation.xml"));

            Root result = resultObject as Root;

            Errors.ErrorObservable.GetInstance().Unregister(errorObserver);

            result.Reservations.Count.Should().Be(2);
            result.Reservations[0].Id.Should().Be("03a804fa");
            result.Reservations[0].HotelCode.Should().Be("62818");
            result.Reservations[1].Id.Should().Be("03a804fb");
            result.Reservations[1].HotelCode.Should().Be("62818");

            result.Reservations[0].RoomStays.Count.Should().Be(2);
            result.Reservations[0].RoomStays[0].Code.Should().Be("6281801");
            result.Reservations[0].RoomStays[0].GuestName.Should().Be("S*****");
            result.Reservations[0].RoomStays[0].RateCode.Should().Be("65090");
            result.Reservations[0].RoomStays[0].GuestId.Should().Be("1");
            result.Reservations[0].RoomStays[0].Text.Should().BeEmpty();
            result.Reservations[0].RoomStays[0].Name.Should().BeEmpty();
            result.Reservations[0].RoomStays[1].Code.Should().Be("6281802");
            result.Reservations[0].RoomStays[1].GuestName.Should().Be("D****");
            result.Reservations[0].RoomStays[1].RateCode.Should().Be("65090");
            result.Reservations[0].RoomStays[1].GuestId.Should().Be("2");

            result.Reservations[0].Guests.Count.Should().Be(2);
            result.Reservations[0].Guests[0].GivenName.Should().Be("S*****");
            result.Reservations[0].Guests[0].Surname.Should().Be("K**************");
            result.Reservations[0].Guests[0].GuestId.Should().Be("1");
            result.Reservations[0].Guests[1].GivenName.Should().Be("D****");
            result.Reservations[0].Guests[1].Surname.Should().Be("T**************");
            result.Reservations[0].Guests[1].GuestId.Should().Be("2");

            errorObserver.GetErrors().Count.Should().Be(8);
        }

        //[Fact]
        //public void Deserialize()
        //{
        //    Setup - for simplicities sake i just use what the test above already tests, for now tho, if above test breaks, this one breaks too
        //    var source = new Root();
        //    Mapper.Map(GetFakedSerializationConfigurations(), System.IO.File.ReadAllText(@".\Xmls\BOO_Reservation.xml"), source);

        //    Actual test
        //    var errorObserver = new TestErrorObserver();
        //    Errors.ErrorObservable.GetInstance().Register(errorObserver);

        //    string template = System.IO.File.ReadAllText(@".\Xmls\SandboxTemplate.xml");
        //    string result = Mapper.Map(GetFakedDeserializationConfiguration(), template, source);

        //    Errors.ErrorObservable.GetInstance().Unregister(errorObserver);

        //    string expectedResult = System.IO.File.ReadAllText(@".\Xmls\ExpectedSandboxResult.xml");
        //    XElement xResult = XElement.Parse(result);
        //    XElement xExpectedResult = XElement.Parse(expectedResult);

        //    xResult.Should().BeEquivalentTo(xExpectedResult);

        //    errorObserver.GetErrors().Count.Should().Be(12);
        //}

        //[Fact]
        //public void CheckIfSaveAndLoadMementoWorks()
        //{
        //    MappingConfiguration source = GetFakedDeserializationConfiguration();

        //    string serialized = Mapper.GetMemento(source);
        //    MappingConfiguration target = Mapper.LoadMemento(serialized);

        //    source.Should().BeEquivalentTo(target);
        //}

        [Fact]
        public void FailedScopeXPathTraversalMapping()
        {
            System.Type testType = typeof(Root);

            var reservationScope = new ScopeTraversalComposite(
                new List<ScopeTraversalComposite>(),
                new List<Mapping>(),
                new Xml.XmlGetScope("//ReservationsList/HotelReservation"),
                new Memory.AdaptableTraversalThis(),
                new Memory.AdaptableTraversalTemplate("Reservations"),
                new Memory.AdaptableCreateNewChild()
            );

            var contextFactory = new Contexts.ContextFactory(
                new Xml.XmlObjectConverter(),
                new Memory.AdaptableTargetInstantiator(testType.Assembly.FullName, testType.FullName)
            );

            var mappingConfiguration = new MappingConfiguration(reservationScope, contextFactory);

            var errorObserver = new TestErrorObserver();
            Errors.ErrorObservable.GetInstance().Register(errorObserver);

            object result = Mapper.Map(mappingConfiguration, System.IO.File.ReadAllText(@".\Xmls\BOO_Reservation.xml"));

            Errors.ErrorObservable.GetInstance().Unregister(errorObserver);

            errorObserver.GetErrors().Should().NotBeEmpty();
        }

        //private MappingConfiguration GetFakedDeserializationConfiguration()
        //{
        //    string searchPath = "GuestId";
        //    string xPath = "./RoomTypes/RoomType/RoomDescription/@GuestLastName";
        //    string adaptablePath = "../Guests{'PropertyName':'GuestId','Value':'{{searchResult}}'}/Surname";

        //    var roomStayTestObjectFail = XPathConfiguration.CreateMapConfiguration("./RoomTypes/RoomType/RoomDescription/Text", "Test");
        //    var roomStayNameXPathFail = XPathConfiguration.CreateMapConfiguration("./RoomTypes/RoomType/RoomDescription/@Naem", "Name");
        //    var roomGuestLastNameSearch = XPathConfiguration.CreateSearchConfiguration(xPath, adaptablePath, searchPath);
        //    var roomStayCodeMap = XPathConfiguration.CreateMapConfiguration("./RoomTypes/RoomType/@RoomTypeCode", "Code");
        //    var roomStayConfiguration = new List<XPathConfiguration>() { roomStayCodeMap, roomGuestLastNameSearch, roomStayNameXPathFail, roomStayTestObjectFail };
        //    var roomStayScope = XPathConfiguration.CreateScopeConfiguration("./RoomStays/RoomStay", "RoomStays", roomStayConfiguration);

        //    var reservationHotelCodeMap = XPathConfiguration.CreateMapConfiguration(@"./ResGlobalInfo/BasicPropertyInfo/@HotelCode", "HotelCode");
        //    var reservationIdMap = XPathConfiguration.CreateMapConfiguration(@"./ResGlobalInfo/HotelReservationIDs/HotelReservationID[@ResID_Type='5']/@ResID_Value", "Id");
        //    var reservationConfiguration = new List<XPathConfiguration>() { reservationIdMap, reservationHotelCodeMap, roomStayScope };
        //    var reservationScope = XPathConfiguration.CreateScopeConfiguration("//ReservationsList/HotelReservation", "Reservations", reservationConfiguration);

        //    return reservationScope;
        //}

        private MappingConfiguration GetFakedSerializationConfiguration()
        {
            var roomStayGuestNameSearchMap = new Mapping(
                new Xml.XmlGetSearch(
                    "../../ResGuests/ResGuest[@ResGuestRPH='{{searchResult}}']/Profiles/ProfileInfo/Profile/Customer/PersonName/GivenName",
                    "./ResGuestRPHs/ResGuestRPH/@RPH"
                ),
                new Memory.AdaptableSetOnProperty("GuestName")
            );

            var roomStayTestObjectFail = new Mapping(
                new Xml.XmlGet("./RoomTypes/RoomType/RoomDescription/Text"),
                new Memory.AdaptableSetOnProperty("Test")
            );

            var roomStayNameXPathFail = new Mapping(
                new Xml.XmlGet("./RoomTypes/RoomType/RoomDescription/@Naem"),
                new Memory.AdaptableSetOnProperty("Name")
            );

            var roomStayGuestId = new Mapping(
                new Xml.XmlGet("./ResGuestRPHs/ResGuestRPH/@RPH"),
                new Memory.AdaptableSetOnProperty("GuestId")
            );

            var roomStayCodeMap = new Mapping(
                new Xml.XmlGet("./RoomTypes/RoomType/@RoomTypeCode"),
                new Memory.AdaptableSetOnProperty("Code")
            );

            var roomStayRateCodeMap = new Mapping(
                new Xml.XmlGet("./RoomRates/RoomRate/@RatePlanCode"),
                new Memory.AdaptableSetOnProperty("RateCode")
            );

            var roomStayScope = new ScopeTraversalComposite(
                new List<ScopeTraversalComposite>(),
                new List<Mapping>()
                {
                    roomStayGuestNameSearchMap,
                    roomStayTestObjectFail,
                    roomStayNameXPathFail,
                    roomStayGuestId,
                    roomStayCodeMap,
                    roomStayRateCodeMap
                },
                new Xml.XmlGetScope("./RoomStays/RoomStay"),
                new Memory.AdaptableTraversalThis(),
                new Memory.AdaptableTraversalTemplate("RoomStays"),
                new Memory.AdaptableCreateNewChild()
            );

            var guestIdMap = new Mapping(
                new Xml.XmlGet("./@ResGuestRPH"),
                new Memory.AdaptableSetOnProperty("GuestId")
            );

            var guestGivenNameMap = new Mapping(
                new Xml.XmlGet("./Profiles/ProfileInfo/Profile/Customer/PersonName/GivenName"),
                new Memory.AdaptableSetOnProperty("GivenName")
            );

            var guestSurNameMap = new Mapping(
                new Xml.XmlGet("./Profiles/ProfileInfo/Profile/Customer/PersonName/Surname"),
                new Memory.AdaptableSetOnProperty("Surname")
            );

            var guestScope = new ScopeTraversalComposite(
                new List<ScopeTraversalComposite>(),
                new List<Mapping>()
                {
                    guestIdMap,
                    guestGivenNameMap,
                    guestSurNameMap
                },
                new Xml.XmlGetScope("./ResGuests/ResGuest"),
                new Memory.AdaptableTraversalThis(),
                new Memory.AdaptableTraversalTemplate("Guests"),
                new Memory.AdaptableCreateNewChild()
            );

            var reservationHotelCodeMap = new Mapping(
                new Xml.XmlGet("./RoomStays/RoomStay/BasicPropertyInfo/@HotelCode"),
                new Memory.AdaptableSetOnProperty("HotelCode")
            );

            var reservationIdMap = new Mapping(
                new Xml.XmlGet("./ResGlobalInfo/HotelReservationIDs/HotelReservationID[@ResID_Type='18']/@ResID_Value"),
                new Memory.AdaptableSetOnProperty("Id")
            );

            var reservationScope = new ScopeTraversalComposite(
                new List<ScopeTraversalComposite>()
                {
                    roomStayScope,
                    guestScope
                },
                new List<Mapping>()
                {
                    reservationHotelCodeMap,
                    reservationIdMap
                },
                new Xml.XmlGetScope("//HotelReservations/HotelReservation"),
                new Memory.AdaptableTraversalThis(),
                new Memory.AdaptableTraversalTemplate("Reservations"),
                new Memory.AdaptableCreateNewChild()
            );

            System.Type testType = typeof(Root);

            var contextFactory = new Contexts.ContextFactory(
                new Xml.XmlObjectConverter(),
                new Memory.AdaptableTargetInstantiator(testType.Assembly.FullName, testType.FullName)
            );

            var mappingConfiguration = new MappingConfiguration(reservationScope, contextFactory);

            return mappingConfiguration;
        }
    }
}