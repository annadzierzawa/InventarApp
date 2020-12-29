using InventarApp.Domain.Entities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    public class LocalizationTests
    {
        [Fact]
        public void GivenCorrectData_WhenCreatingNewLocalization_ThenLocalizationIsCreated()
        {
            // given
            var name = "New localization";

            //when
            var localization = new Localization(name);

            //then
            localization.Name.ShouldBe(name);
        }
    }
}
