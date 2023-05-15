using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Helper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;


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
        public IResult Add(IFormFile file, BillImage billImage)
        {
            var resultToFileUpload = _imageHelper.Upload(file, PathConstant.ImagePath);
            if (!resultToFileUpload.Success)
            {
                return resultToFileUpload;
            }
            billImage.ImagePath = PathConstant.ImagePath;
            billImage.Date = DateTime.Now;
            _billImageDal.Add(billImage);
            return new SuccessResult(Messages.BillImageAdded);
        }

        //Delete
        public IResult Delete(BillImage billImage)
        {
            var result = _imageHelper.Delete(PathConstant.ImagePath + billImage.ImagePath);
            if (!result.Success)
            {
                return result;
            }
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
        public IResult Update(IFormFile file, BillImage billImage)
        {
            var result = _imageHelper.Update(file, PathConstant.ImagePath + billImage.ImagePath, PathConstant.ImagePath);
            if (!result.Success)
            {
                return result;
            }
            billImage.Date = DateTime.Now;
            billImage.ImagePath = PathConstant.ImagePath;
            _billImageDal.Update(billImage);
            return new SuccessResult(Messages.BillImageUpdated);
        }
    }
}
