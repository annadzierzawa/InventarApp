using InventarApp.Domain.Entities;
using InventarApp.Domain.Enums;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    public class FailureReportTests
    {
        [Fact]
        public void GivenCorrectData_WhenCreatingNewFailureRepory_ThenFailureReportIsCreated()
        {
            // given
            var description = "New localization";
            var resourceId = 1;
            var reporterId = 2;
            var date = DateTime.Now;
            var status = RepairStatusEnum.Done;

            //when
            var localization = new FailureReport(description, resourceId, reporterId, date, status);

            //then
            localization.FailureDescription.ShouldBe(description);
            localization.ResourceId.ShouldBe(resourceId);
            localization.ReporterId.ShouldBe(reporterId);
            localization.DateOfReporting.ShouldBe(date);
            localization.RepairStatus.ShouldBe(status);
        }
    }
}
