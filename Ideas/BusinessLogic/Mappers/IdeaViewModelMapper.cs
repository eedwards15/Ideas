using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public static class IdeaViewModelMapper
    {

        public static Core.Dtos.IdeaViewModel  MapTo(this Core.Database.Idea ideaViewModel)
        {
            return new Core.Dtos.IdeaViewModel()
            {
                Id = ideaViewModel.Id,
                Title = ideaViewModel.Title,
                Idea_text = ideaViewModel.Idea_text,
                Created_at = ideaViewModel.Created_at,
                Updated_at = ideaViewModel.Updated_at
            };
        }


        public static List<Core.Dtos.IdeaViewModel> MapTo(this List<Core.Database.Idea> ideaViewModels)
        {
            return ideaViewModels.Select(MapTo).ToList();
        }


    }
}
