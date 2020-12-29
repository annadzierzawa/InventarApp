using InventarApp.Domain.Entities;
using InventarApp.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using Xunit;

namespace DomainTests
{
    public class UserTests
    {
        [Fact]
        public void GivenCorrectData_WhenCreatingNewUser_ThenUserIsCreated()
        {
            var user = new User("Anna", "Wanna", "AniWan", "AnnWanna1!", RoleEnum.Admin);

            user.Name.ShouldBe("Anna");
            user.Surname.ShouldBe("Wanna");
            user.Login.ShouldBe("AniWan");
            user.Password.ShouldBe("AnnWanna1!");
            user.Role.ShouldBe(RoleEnum.Admin);
        }
    }
}
