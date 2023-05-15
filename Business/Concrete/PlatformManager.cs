using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlatformManager:IPlatformService
    {
        IPlatformDal _platformDal;

        public PlatformManager(IPlatformDal platformDal)
        {
            _platformDal = platformDal;
        }

        //Add
        public IResult Add(Platform platform)
        {
            _platformDal.Add(platform);
            return new SuccessResult(Messages.PlatformAdded);
        }

        //Delete
        public IResult Delete(Platform platform)
        {
            _platformDal.Delete(platform);
            return new SuccessResult(Messages.PlatformDeleted);
        }

        //GetAll
        public IDataResult<List<Platform>> GetAll()
        {
            return new SuccessDataResult<List<Platform>>(_platformDal.GetAll(), Messages.PlatformsListed);
        }

        //GetById
        public IDataResult<Platform> GetById(int id)
        {
            return new SuccessDataResult<Platform>(_platformDal.Get(p => p.Id == id), Messages.PlatformListed);
        }

        //Update
        public IResult Update(Platform platform)
        {
            _platformDal.Update(platform);
            return new SuccessResult(Messages.PlatformUpdated);
        }
    }
}
