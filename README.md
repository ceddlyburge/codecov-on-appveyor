# Integrating CodeCov and AppVeyor 

[![Build status](https://ci.appveyor.com/api/projects/status/d88f1y3p20cudhfc?svg=true)](https://ci.appveyor.com/project/ceddlyburge/codecov-on-appveyor)


Companion repository to the blog post [CodeCov Test Coverage Integration](https://www.appveyor.com/blog/2017/03/17/codecov/) on the AppVeyor website.

The post is written from the point of view of someone (me) who is already proficient in C# and unit testing, but was new to AppVeyor and integrating CodeCov with GitHub.

It contains from scratch steps to upload test coverage to [CodeCov](http://codecov.io/) for a sample C# project using [XUnit](https://xunit.github.io/) and [OpenCover](https://github.com/OpenCover/opencover). 

This is the repo that I created to test the blog post, which you can use for clues if you have trouble following the instructions in the post.

Obviously, it being a post about Code Coverage, there is a badge to display the results :)

[![Code Coverage](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/coverage.svg)](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor)

Sunburst code coverage graphic (would be more interesting with more code / tests)

[![Code Coverage Sunburst](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/sunburst.svg)](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/sunburst.svg)

Icicles code coverage graphic (would also be more interesting with more code / tests)

[![Code Coverage Icicles](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/icicle.svg)](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/icicle.svg)

Grid code coverage graphic (and again, would also be more interesting with more code / tests)

[![Code Coverage Grid](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/tree.svg)](https://codecov.io/gh/ceddlyburge/codecov-on-appveyor/branch/master/graphs/tree.svg)
