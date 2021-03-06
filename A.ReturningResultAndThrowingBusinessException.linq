<Query Kind="Program" />

// メソッド定義
string ReturningResultAndThrowingBusinessException(string name)
{
  if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
	
  return $"Hello! {name}";
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  try
  {
    var result = ReturningResultAndThrowingBusinessException(userName);
    Console.WriteLine(result);
  }
  catch (ArgumentNullException ex)
  {
    Console.WriteLine($"argument `{ex.ParamName}` is empty.");
  }
}