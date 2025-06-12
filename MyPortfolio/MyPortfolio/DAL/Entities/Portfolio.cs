using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        [Key]
        public int PortfolyoID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageURL { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
