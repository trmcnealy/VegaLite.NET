using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using VegaLite.Schema;

namespace VegaLite
{
    public struct SplomData : IEnumerable<float>
    {
        
        [JsonProperty("Iteration",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public int Iteration { get; set; }
        
        [JsonProperty("SwarmIndex",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public int SwarmIndex { get; set; }
        
        [JsonProperty("Particle",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public int Particle { get; set; }
        
        [JsonProperty("km",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float km { get; set; }
        
        [JsonProperty("kF",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float kF { get; set; }
        
        [JsonProperty("kf",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float kf { get; set; }
        
        [JsonProperty("ye",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float ye { get; set; }
        
        [JsonProperty("LF",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float LF { get; set; }
        
        [JsonProperty("Lf",
                      NamingStrategyType = typeof(DefaultNamingStrategy))]
        public float Lf { get; set; }

        public SplomData(int    iteration,
                         int    swarmIndex,
                         int    particle,
                         double km,
                         double kF,
                         double kf,
                         double ye,
                         double lF,
                         double lf)
        {
            Iteration  = iteration;
            SwarmIndex = swarmIndex;
            Particle   = particle;
            this.km    = (float)km;
            this.kF    = (float)kF;
            this.kf    = (float)kf;
            this.ye    = (float)ye;
            LF         = (float)lF;
            Lf         = (float)lf;
        }

        public SplomData(string data)
        {
            string[] columns = data.Split(new char[]
                                          {
                                              ','
                                          },
                                          StringSplitOptions.RemoveEmptyEntries);

            int index = 0;

            Iteration  = int.Parse(columns[index++]);
            SwarmIndex = int.Parse(columns[index++]);
            Particle   = int.Parse(columns[index++]);
            km         = float.Parse(columns[index++]);
            index++;
            kF = float.Parse(columns[index++]);
            index++;
            kf = float.Parse(columns[index++]);
            index++;
            ye = float.Parse(columns[index++]);
            index++;
            LF = float.Parse(columns[index++]);
            index++;
            Lf = float.Parse(columns[index]);
        }

        public IEnumerator<float> GetEnumerator()
        {
            yield return Iteration;
            yield return SwarmIndex;
            yield return Particle;
            yield return km;
            yield return kF;
            yield return kf;
            yield return ye;
            yield return LF;
            yield return Lf;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public sealed class SplomChart : Chart<SplomData>
    {
        private static readonly Func<Guid, int, Specification> _specification = (id,
                                                                                 maxIteration) => new Specification()
        {
            Repeat = new RepeatMapping()
            {
                Row = new List<string>()
                {
                    "km",
                    "kF",
                    "kf",
                    "ye",
                    "LF",
                    "Lf"
                },
                Column = new List<string>()
                {
                    "km",
                    "kF",
                    "kf",
                    "ye",
                    "LF",
                    "Lf"
                }
            },
            Spec = new SpecClass()
            {
                DataSource = new DataSource()
                {
                    Name = $"dataset_{id.ToString().Replace("-", "")}",
                    Url = "",
                    Format = new DataFormat()
                    {
                        Type = "arrow"
                    }
                },
                Transform = new List<Transform>()
                {
                    new Transform()
                    {
                        Filter = new Predicate()
                        {
                            Selection = "Select"
                        }
                    }
                },
                Mark = BoxPlot.Circle,
                Encoding = new Encoding()
                {
                    X = new XClass()
                    {
                        Type = StandardType.Quantitative,
                        Field = new RepeatRef()
                        {
                            Repeat = RepeatEnum.Column
                        }
                    },
                    Y = new YClass()
                    {
                        Type = StandardType.Quantitative,
                        Field = new RepeatRef()
                        {
                            Repeat = RepeatEnum.Row
                        }
                    },
                    Color = new DefWithConditionMarkPropFieldDefGradientStringNull()
                    {
                        Condition = new ConditionalPredicateValueDefGradientStringNullClass()
                        {
                            Type = StandardType.Nominal,
                            Selection = "Brush",
                            Field = "SwarmIndex",
                            Scale = new Scale()
                            {
                                Scheme = ColorThemes.Cyclical.Sinebow
                            }
                        },
                        Value = "grey"
                    },
                    Opacity = new DefWithConditionMarkPropFieldDefNumber()
                    {
                        Condition = new ConditionalDef()
                        {
                            Selection = "LegendSelect", Value = 1.0
                        },
                        Value = 0.2
                    }
                },
                Selection = new Dictionary<string, SelectionDef>()
                {
                    {
                        "Brush", new SelectionDef()
                        {
                            Type = SelectionDefType.Interval,
                            Resolve = SelectionResolution.Union
                        }
                    },
                    {
                        "Select", new SelectionDef()
                        {
                            Type = SelectionDefType.Single,
                            Fields = new List<string>()
                            {
                                "Iteration"
                            },
                            Init = new Dictionary<string, InitValue>()
                            {
                                {
                                    "Iteration", 0
                                }
                            },
                            Bind = new Dictionary<string, AnyStream>()
                            {
                                {
                                    "Iteration", new AnyBinding()
                                    {
                                        Input = "range",
                                        Min   = 0.0,
                                        Max   = maxIteration
                                    }
                                }
                            }
                        }
                    },
                    {
                        "LegendSelect", new SelectionDef()
                        {
                            Type = SelectionDefType.Multi,
                            Fields = new List<string>()
                            {
                                "SwarmIndex"
                            },
                            Bind = SelectionLegendBinding.Legend
                        }
                    }
                }
            }
        };

        public SplomData[] DataSet { get; }

        #region Constructors

        public SplomChart(SplomData[] data)
            : base((id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   })
        {
            DataSet = data;
        }

        public SplomChart(SplomData[] data,
                          string      datasetName)
            : base((id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   datasetName)
        {
            DataSet = data;
        }

        public SplomChart(string      title,
                          SplomData[] data)
            : base(title,
                   (id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   })
        {
            DataSet = data;
        }

        public SplomChart(string      title,
                          SplomData[] data,
                          string      datasetName)
            : base(title,
                   (id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   datasetName)
        {
            DataSet = data;
        }

        public SplomChart(string      title,
                          SplomData[] data,
                          int         width,
                          int         height)
            : base(title,
                   (id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   width,
                   height)
        {
            DataSet = data;
        }

        public SplomChart(string      title,
                          SplomData[] data,
                          string      datasetName,
                          int         width,
                          int         height)
            : base(title,
                   (id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   datasetName,
                   width,
                   height)
        {
            DataSet = data;
        }

        public SplomChart(SplomData[] data,
                          int         width,
                          int         height)
            : base((id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   width,
                   height)
        {
            DataSet = data;
        }

        public SplomChart(SplomData[] data,
                          string      datasetName,
                          int         width,
                          int         height)
            : base((id) =>
                   {
                       return _specification(id,
                                             data.Max(p => p.Iteration));
                   },
                   datasetName,
                   width,
                   height)
        {
            DataSet = data;
        }

        #endregion
    }
}
