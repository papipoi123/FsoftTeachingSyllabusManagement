﻿using Domain.Enum.StatusEnum;

namespace Applications.ViewModels.AssignmentViewModels
{
    public class CreateAssignmentViewModel
    {
        public string AssignmentName { get; set; }
        public double Duration { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
        public bool IsOnline { get; set; }
        public Guid UnitId { get; set; }
    }
}
