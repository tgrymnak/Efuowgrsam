using AutoMapper;
using EfuowGrsam.Services;
using WebAppWithEfuowGrsam.DAL;
using WebAppWithEfuowGrsam.Models;

namespace WebAppWithEfuowGrsam.Services
{
    public class TableService: GenericService<Table, TableModel>
    {
        public TableService() : base(new TestDbEntities()) { }

        protected override void ConfigureAutoMappings()
        {
            Mapper.CreateMap<Table, TableModel>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (TableStatus)src.Status));
            Mapper.CreateMap<TableModel, Table>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (int)src.Status));
        }
    }
}