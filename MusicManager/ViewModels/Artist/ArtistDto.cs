using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace MusicManager.ViewModels.Artist
{
    public class ArtistDto : BaseArtistDto
    {
        public int Id { get; set; }
        public int GetAge()
        {
            int age;
            if (DeathDate == null)
            {
                age = DateTime.Now.Year - Convert.ToDateTime(this.BirthDate).Year;
            }
            else
            {
                age = Convert.ToDateTime(this.DeathDate).Year - Convert.ToDateTime(this.BirthDate).Year;
            }
            return age;
        }

        public string GetLastName()
        {
            string lastName = string.Empty;
            if (BirthName.Contains(' '))
            {
                int spaceIndex = BirthName.LastIndexOf(' ');
                lastName = this.BirthName.Substring(spaceIndex);
            }
            else
            {
                lastName = BirthName;
            }
            return lastName;
        }
        [DisplayName("Last Name")]
        public string LastName { get => this.GetLastName(); }
    }
}
