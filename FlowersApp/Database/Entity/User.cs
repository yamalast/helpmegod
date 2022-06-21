namespace FlowersApp.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(32)]
        public string UserFN { get; set; }

        [Required]
        [StringLength(32)]
        public string UserLN { get; set; }

        [Required]
        [StringLength(32)]
        public string UserMN { get; set; }

        [Required]
        [StringLength(32)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(45)]
        public string UserPassword { get; set; }

        public int Role_RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
