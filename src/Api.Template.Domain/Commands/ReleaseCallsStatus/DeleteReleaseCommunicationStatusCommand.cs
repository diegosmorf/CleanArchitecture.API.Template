﻿using Api.Common.Cqrs.Core.Commands;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Template.Domain.Commands.ReleaseCallsStatus
{
    public class DeleteReleaseCallStatusCommand : Command
    {
        public DeleteReleaseCallStatusCommand(Guid id)
        {
            Id = id;
        }

        [Required] public Guid Id { get; protected set; }
    }
}