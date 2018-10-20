# turing.net
Turing Robot (图灵机器人) .NET SDK http://www.tuling123.com

How to install:

```
PM> Install-Package Turing.NET
```
How to use:
```
var turing = new TuringAgent(config);
var tulingResponse = turing.Request(new TuringRequest
{
	Perception = new TuringRequestPerception
	{
		InputText = new TuringInputText { Text = request.Text }
	}
});
```

API Docs: https://www.kancloud.cn/turing/www-tuling123-com/718227
