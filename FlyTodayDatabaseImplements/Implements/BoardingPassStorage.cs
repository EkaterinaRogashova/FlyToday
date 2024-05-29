using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class BoardingPassStorage : IBoardingPassStorage
    {

        public BoardingPassViewModel? GetElement(BoardingPassSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            var query = context.BoardingPasses.Include(x => x.Place).Include(x => x.Ticket);

            if (model.Id.HasValue)
            {
                return query.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            }

            if (model.TicketId.HasValue)
            {
                return query.FirstOrDefault(x => x.TicketId == model.TicketId)?.GetViewModel;
            }

            if (model.PlaceId.HasValue)
            {
                return query.FirstOrDefault(x => x.PlaceId == model.PlaceId)?.GetViewModel;
            }

            return null;
        }

        public List<BoardingPassViewModel> GetFilteredList(BoardingPassSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<BoardingPassViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.BoardingPasses.Select(x => x.GetViewModel).ToList();
        }

        public BoardingPassViewModel? Insert(BoardingPassBindingModel model)
        {
            var newBoardingPass = BoardingPass.Create(model);
            if (newBoardingPass == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.BoardingPasses.Add(newBoardingPass);
            context.SaveChanges();
            return newBoardingPass.GetViewModel;
        }
    }
}
