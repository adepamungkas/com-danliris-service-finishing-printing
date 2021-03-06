﻿using Com.Danliris.Service.Finishing.Printing.Lib.Models.Master.Machine;
using Com.Moonlay.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.Danliris.Service.Finishing.Printing.Lib.Models.Kanban
{
    public class KanbanInstructionModel : StandardEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int KanbanId { get; set; }
        public virtual KanbanModel Kanban { get; set; }
        public ICollection<KanbanStepModel> Steps { get; set; }
    }
}