using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Helper.ImageHelper.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillImageManager : IBillImageService
    {
        IBillImageDal _billImageDal;
        ImageHelper _imageHelper;

        public BillImageManager(ImageHelper imageHelper, IBillImageDal billImageDal)
        {
            _billImageDal = billImageDal;
            _imageHelper = imageHelper;
        }

        //Add
        [ValidationAspect(typeof(BillImageValidator))]
        public IResult Add(BillImage billImage)
        {
            _billImageDal.Add(billImage);
            return new SuccessResult(Messages.BillImageAdded);
        }

        //Delete
        public IResult Delete(BillImage billImage)
        {
            _billImageDal.Delete(billImage);
            return new SuccessResult(Messages.BillImageDeleted);
        }

        //GetAll
        public IDataResult<List<BillImage>> GetAll()
        {
            return new SuccessDataResult<List<BillImage>>(_billImageDal.GetAll(), Messages.BillImagesListed);
        }

        //GetById
        public IDataResult<BillImage> GetById(int id)
        {
            return new SuccessDataResult<BillImage>(_billImageDal.Get(b => b.Id == id), Messages.BillImageListed);
        }

        //Update
        public IResult Update(BillImage billImage)
        {
            _billImageDal.Update(billImage);
            return new SuccessResult(Messages.BillImageUpdated);
        }
    }
}
