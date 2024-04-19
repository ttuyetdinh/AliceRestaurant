using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.ChangeLogDTO
{
    public class ChangeLogDTO
    {
        public int? ChangeLogId { get; set; }
        public int? ChangeLogItem { get; set; }
        public int? RecordId { get; set; }
        public string? TableName { get; set; }
        public string? ColumnName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? Action { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}