using BusinessLogic.Utils;


public static class IdeaViewModelMapper
{
        public static Core.Database.Idea MapToIdea(this Core.Dtos.IdeaViewModel ideaViewModel)
        {
            if(ideaViewModel.Title == null || ideaViewModel.Title == "")
                throw new Exception("Title cannot be null or empty");
            
            if(BusinessLogic.Utils.TextValidation.ContainsHtmlOrJavascript(ideaViewModel.Title))
                throw new Exception("Title cannot contain HTML or JavaScript");

            if(BusinessLogic.Utils.TextValidation.ContainsHtmlOrJavascript(ideaViewModel.Idea_text))
                throw new Exception("Idea_text cannot contain HTML or JavaScript");


            return new Core.Database.Idea
            {
                Id = ideaViewModel.Id,
                Title = ideaViewModel.Title,
                Idea_text = ideaViewModel.Idea_text,
                Created_at = ideaViewModel.Created_at,
                Updated_at = ideaViewModel.Updated_at
            };
            
        }

        public static List<Core.Database.Idea> MapToIdea(this List<Core.Dtos.IdeaViewModel> ideaViewModels)
        {
            return ideaViewModels.Select(MapToIdea).ToList();
        }


}