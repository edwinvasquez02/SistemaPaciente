﻿using AutoMapper;
using SistemaPaciente.Core.Application.Interfaces.Repositories;
using SistemaPaciente.Core.Application.Interfaces.Services;
using System.Linq.Expressions;

namespace SistemaPaciente.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Model> : IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where Model : class
        where ViewModel : class

    {
        private readonly IMapper _mapper;
        private readonly IGenericRepositoryAsync<Model> _repositoryAsync;

        public GenericService(IMapper mapper, IGenericRepositoryAsync<Model> repositoryAsync)
        {
            _mapper = mapper;
            _repositoryAsync = repositoryAsync;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel viewModel)
        {
            Model entity = _mapper.Map<Model>(viewModel);
            entity = await _repositoryAsync.AddAsync(entity);
            SaveViewModel entityVm = _mapper.Map<SaveViewModel>(entity);
            return entityVm;
        }

        public virtual async Task Delete(int id)
        {
            var entity = await _repositoryAsync.GetByIdAsync(id);
            await _repositoryAsync.DeleteAsync(entity);
        }

        public virtual async Task<List<ViewModel>> GetAll()
        {
            var entityList = await _repositoryAsync.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entityList);
        }

        public virtual async Task<SaveViewModel> GetById(int id)
        {
            var entity = await _repositoryAsync.GetByIdAsync(id);
            SaveViewModel saveViewModel = _mapper.Map<SaveViewModel>(entity);
            return saveViewModel;
        }

        public virtual async Task Update(SaveViewModel viewModel, int id)
        {
            Model entity = _mapper.Map<Model>(viewModel);
            await _repositoryAsync.UpdateAsync(entity, id);
        }
        public virtual bool Any(Expression<Func<Model, bool>> predicate)
        {
            return  _repositoryAsync.Any(predicate);
        }
    }
}
