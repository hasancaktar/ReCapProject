﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update (Rental rental);
        IResult Get(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int id);
    }
}
