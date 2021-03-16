using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarlinMotorRepairs.Models
{
        public class Car
        {

            public int ID { get; set; }

            [Display(Name = "Job No")]
            [Required]
            [Range(1, 30)]
            public int JobNo { get; set; }

            [Display(Name = "Car Owner")]
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [Required]
            [StringLength(60, MinimumLength = 3)]
            public string CarOwner { get; set; }


            [Display(Name = "Car Make")]
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [Required]
            [StringLength(60, MinimumLength = 3)]
            public string CarMake { get; set; }

            [Display(Name = "Job Description")]
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [Required]
            [StringLength(60, MinimumLength = 2)]
            public string JobDesc { get; set; }

            [Display(Name = "Received On")]
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime ReceivedOn { get; set; }


            [Display(Name = "Job Status")]
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [Required]
            [StringLength(40, MinimumLength = 4)]
            public string JobStatus { get; set; }

            [Display(Name = "Price Of Repair")]
            [Required]
            [Range(1, 100000)]
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }



        }

        public class CarsDBContext : ApplicationDbContext
        {
            public DbSet<Car> Cars { get; set; }
        }


    }