#region License
// Copyright (c) 2018, FluentMigrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace FluentMigrator.Runner.Generators.DB2.iSeries
{
    public class Db2ISeriesGenerator : Db2Generator
    {
        public Db2ISeriesGenerator()
            : this(new Db2ISeriesQuoter())
        {
        }

        public Db2ISeriesGenerator(Db2ISeriesQuoter quoter)
            : base(quoter)
        {
        }
    }
}
