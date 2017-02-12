namespace GrIDCRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employment
    {
        public int EmploymentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }
    }
}
