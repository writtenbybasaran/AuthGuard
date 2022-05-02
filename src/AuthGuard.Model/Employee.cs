using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AuthGuard.Common.Enums;
using AuthGuard.Model.BaseModel;

namespace AuthGuard.Model
{
    public class Employee : IEntity<int>,ISoftDelete,ICreateAudit
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        #region prop

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        #endregion
    }
}
