namespace GrIDCRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventLog
    {
        public int Id { get; set; }

        public string MethodName { get; set; }

        public string Type { get; set; }

        public string Message { get; set; }
    }
}
