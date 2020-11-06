using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data
{
    abstract class GenericCommanderServices<TEntity, TDTO> : IGenericCommanderServices<TEntity, TDTO>
        where TEntity : EntityBase
        where TDTO : class
    {
        readonly ICommander<TEntity> _commander;
        readonly IMapper _mapper;

        public GenericCommanderServices(ICommander<TEntity> commander, IMapper mapper)
        {
            _commander = commander;
            _mapper = mapper;
        }

        public virtual async Task<bool> CreateAsync(TDTO dto)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(dto);

                return await _commander.AddAsync(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<bool> UpdateAsync(TDTO dto)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(dto);

                return await _commander.UpdateAsync(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task DeleteAsync(Guid dto)
        {
            try
            {
                if (dto == Guid.Empty)
                    throw new ArgumentException("Invalid id", nameof(dto));

                await _commander.DeleteAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
