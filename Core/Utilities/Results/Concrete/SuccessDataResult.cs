﻿using Core.Utilities.Entities.Abstract;

namespace Core.Utilities.Results.Concrete;

public class SuccessDataResult<T>:DataResult<T>
{
	public SuccessDataResult() :base(default, true)
	{

	}

    public SuccessDataResult(T data) : base(data, true)
    {

    }

	public SuccessDataResult(string message) :base(default,true,message)
	{
			
	}

    public SuccessDataResult(T data, string message) : base(data, true, message)
    {

    }
}
