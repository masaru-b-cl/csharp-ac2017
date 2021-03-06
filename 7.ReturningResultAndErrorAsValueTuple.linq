<Query Kind="Program" />

// エラーの種類
enum ErrorType
{
  NoError,
  NameIsEmpty,
  // SomeError
}

// メソッド定義
(string result, ErrorType errorType) ReturningResultAndErrorAsValueTuple(string name)
{
  if (string.IsNullOrEmpty(name))
  {
    return (null, ErrorType.NameIsEmpty);
  }	

  // some validation with return error code "Exxx";

  return ($"Hello! {name}", ErrorType.NoError);
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var (result, errorType) = ReturningResultAndErrorAsValueTuple(userName);
  switch(errorType)
  {
    case ErrorType.NoError :
      Console.WriteLine(result);
      return;
  
    case ErrorType.NameIsEmpty :
      Console.WriteLine("name is empty!");
      return;
  	
    // case ErrorType.SomeError :
    //   error handling
    //   return;
  }
}
