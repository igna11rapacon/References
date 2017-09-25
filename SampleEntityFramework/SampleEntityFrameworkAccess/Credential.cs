using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameworkAccess
{
    public class Credential
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CredentialId { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
    }
}
