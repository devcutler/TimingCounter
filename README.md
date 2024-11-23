# TimingCounter

### Usage

#### Installing
```sh
# using dotnet CLI
dotnet add package devcutler.TimingCounter
```

```xml
<!-- including in .csproj file -->
<PackageReference Include="devcutler.TimingCounter" Version="1.0.0" />
```

#### Instantiating
```cs
using TimingCounter;

// keep the last thousand samples
int samples = 1000;
Counter fps = new Counter(samples);
```

#### Basic usage
```cs
TimeSpan gamerFPS = TimeSpan.FromMilliseconds(16.66666f);
fps.Tick(gamerFPS);

fps.PerSecond();
// 60
```
