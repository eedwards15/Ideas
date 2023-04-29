using System.Text.RegularExpressions;
using System.Web;

namespace Core.Dtos
{
    //TODO: 
    // 1. Add validation for the Title property to ensure that it is not null or empty.
    // 2. Add validation for the Idea_text property to ensure that it is not null or empty.
    // 3. Add validation for the Idea_text property to ensure that it does not contain HTML or JavaScript.
    // 4. Add validation for the Idea_text property to ensure that it does not contain any of the following words: "alert", "onclick", or "onload".
    // 5. Add validation for Title to ensure that it does not contain HTML or JavaScript.
    // 6. Add validation for Title to ensure that it does not contain any of the following words: "alert", "onclick", or "onload".
    // 7. Move the validation logic for Idea_text to a separate method.
    // 8. Move the validation logic for Title to a separate method.
    // 9. Create Custom Exception Types
    public class IdeaViewModel
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Idea_text { get; set; }
            public DateTime Created_at { get; set; }
            public DateTime Updated_at { get; set; }           
    }
}