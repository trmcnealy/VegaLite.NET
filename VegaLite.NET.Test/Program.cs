using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

using NJsonSchema.CodeGeneration.CSharp;

using NSwag;
using NSwag.CodeGeneration.CSharp;

using Formatting = Newtonsoft.Json.Formatting;
using WriteState = Newtonsoft.Json.WriteState;

namespace VegaLite.Test
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            TestChart();
            //TestMultipleCharts();
        }

        //public static Task<string> Prompt(string message)
        //{
        //    return JSRuntime.Current.InvokeAsync<string>("exampleJsFunctions.showPrompt", message);
        //}

        private static void TestChart()
        {
            HttpClient client = new HttpClient();
            string     data   = client.GetStringAsync("https://raw.githubusercontent.com/vega/vega-lite/master/examples/specs/bar.vl.json").Result;

            Chart         chart;
            Specification vegaLiteSpecification;


            Specification specification = new Specification
            {
                Data = new DataSource()
                {
                    Name = "vegaViewData"
                },
                Encoding = new Encoding()
                {
                    Color = new DefWithConditionMarkPropFieldDefGradientStringNull()
                    {
                        Type = StandardType.Nominal,
                        Field = "Type"
                    },
                    X = new XClass()
                    {
                        Type = StandardType.Quantitative,
                        Field = "Day"
                    },
                    Y = new YClass()
                    {
                        Type  = StandardType.Quantitative,
                        Field = "Rate"
                    }
                },
                Layer = new List<LayerSpec>()
                {
                    new LayerSpec()
                    {
                        Mark = new BoxPlotDefClass()
                        {
                            Type = BoxPlot.Line
                        }
                    },
                    new LayerSpec()
                    {
                        Mark = new BoxPlotDefClass()
                        {
                            Type = BoxPlot.Point
                        }
                    }
                },
                Config = new Config()
                {
                    Legend = new LegendConfig()
                    {
                        Orient = LegendOrient.Top
                    }
                }
            };


            //string tempPath = Path.GetTempPath();

            //string dataFile = Path.Combine(tempPath,
            //                               "data");

            //if(!File.Exists(dataFile))
            //{
            //    File.WriteAllBytes(dataFile,
            //                       Examples.Resource.data);
            //}

            int start = 12;
            int count = 1;

            ArraySegment<byte[]> tests = new ArraySegment<byte[]>(ExampleResources,
                                                                  start,
                                                                  count);

            for(int i = 0; i < tests.Count; i++)
            {
                vegaLiteSpecification = Specification.FromJson(System.Text.Encoding.UTF8.GetString(tests[i],
                                                                                                   0,
                                                                                                   tests[i].Length));

                //if (vegaLiteSpecification.DataSource?.Url?.StartsWith("data") == true)
                //{
                //    vegaLiteSpecification.DataSource.Url = "https://raw.githubusercontent.com/vega/vega-datasets/master/" + vegaLiteSpecification.DataSource.Url;
                //}
                //else if (vegaLiteSpecification.Layer?.Count > 0)
                //{
                //    for (int j = tests.Offset; j < vegaLiteSpecification.Layer.Count; j++)
                //    {
                //        if (vegaLiteSpecification.Layer[j]?.DataSource?.Url?.StartsWith("data") == true)
                //        {
                //            vegaLiteSpecification.Layer[j].DataSource.Url = "https://raw.githubusercontent.com/vega/vega-datasets/master/" + vegaLiteSpecification.Layer[j].DataSource.Url;
                //        }
                //    }
                //}

                chart = new Chart(vegaLiteSpecification,
                                  500,
                                  500);

                string html = chart.GetHtml();

                //ChartDisplay chartDisplay = new ChartDisplay();
                ////chartDisplay.Loaded += (sender, e) =>
                ////                       {
                ////                           chartDisplay.webViewControl.NavigateToString("webview loaded");
                ////                       };
                //chartDisplay.NavigateToHtmlString(chart.GetHtml());
                //chartDisplay.ShowDialog();

                //chartDisplay.NavigateTo(new Uri("https://www.microsoft.com"));

                //chart.ShowInBrowser();
            }
        }

        private static void TestMultipleCharts()
        {
            //HttpClient client = new HttpClient();
            //string     data   = client.GetStringAsync("https://raw.githubusercontent.com/vega/vega-lite/tree/master/examples/specs/bar.vl.json").Result;

            //Chart         chart;
            Specification vegaLiteSpecification;
            string        fileData;

            string tempPath = Path.GetTempPath();

            string dataFile = Path.Combine(tempPath,
                                           "data");

            if(!File.Exists(dataFile))
            {
                File.WriteAllBytes(dataFile,
                                   Examples.Resource.data);
            }

            int start = 300;
            int count = 30 * 3;

            ArraySegment<byte[]> tests = new ArraySegment<byte[]>(ExampleResources,
                                                                  start,
                                                                  count);

            MultipleCharts charts = new MultipleCharts("MultipleCharts",
                                                       count / 3,
                                                       3);

            for(int i = 0; i < tests.Count; i++)
            {
                fileData = System.Text.Encoding.UTF8.GetString(tests[i],
                                                               0,
                                                               tests[i].Length);

                fileData = fileData.Replace(@"""url"": ""data",
                                            @"""url"": ""https://raw.githubusercontent.com/vega/vega-datasets/master/data",
                                            StringComparison.InvariantCulture);

                //if (vegaLiteSpecification.DataSource?.Url?.StartsWith("data") == true)
                //{
                //    vegaLiteSpecification.DataSource.Url = "https://raw.githubusercontent.com/vega/vega-datasets/master/" + vegaLiteSpecification.DataSource.Url;
                //}
                //else if (vegaLiteSpecification.Layer?.Count > 0)
                //{
                //    for (int j = tests.Offset; j < vegaLiteSpecification.Layer.Count; j++)
                //    {
                //        if (vegaLiteSpecification.Layer[j]?.DataSource?.Url?.StartsWith("data") == true)
                //        {
                //            vegaLiteSpecification.Layer[j].DataSource.Url = "https://raw.githubusercontent.com/vega/vega-datasets/master/" + vegaLiteSpecification.Layer[j].DataSource.Url;
                //        }
                //    }
                //}

                vegaLiteSpecification = Specification.FromJson(fileData);

                charts[i] = new Chart(vegaLiteSpecification.Description,
                                      vegaLiteSpecification,
                                      500,
                                      500);
            }

            charts.ShowInBrowser();
        }

        //VegaLiteSpecification vegaLiteSpecification = new VegaLiteSpecification
        //{
        //    Description = "",
        //    DataSource = new DataSource()
        //    {
        //        Values = VegaDataset
        //    },
        //    Mark = new BoxPlotDefClass()
        //    {
        //        Type = BoxPlot.Line,
        //        Point = new OverlayMarkDef()
        //        {
        //            Filled = false,
        //            Fill = "white"
        //        }
        //    },
        //    Encoding = new Encoding()
        //    {
        //        Color = new DefWithConditionMarkPropFieldDefGradientStringNull()
        //        {
        //            Type  = StandardType.Nominal,
        //            Field = "symbol"
        //        },
        //        X = new XClass()
        //        {
        //            Type     = StandardType.Temporal,
        //            TimeUnit = TimeUnit.Year,
        //            Field    = "date"
        //        },
        //        Y = new YClass()
        //        {
        //            Type  = StandardType.Quantitative,
        //            Field = "price",
        //            Aggregate = NonArgAggregateOp.Mean
        //        }
        //    }
        //};

        internal static readonly byte[][] ExampleResources = new byte[][]
        {
            Examples.Resource.airport_connections_vl, Examples.Resource.area_vl, Examples.Resource.area_cumulative_freq_vl, Examples.Resource.area_density_vl, Examples.Resource.area_density_facet_vl,
            Examples.Resource.area_density_stacked_vl, Examples.Resource.area_density_stacked_fold_vl, Examples.Resource.area_gradient_vl, Examples.Resource.area_horizon_vl,
            Examples.Resource.area_overlay_vl, Examples.Resource.area_temperature_range_vl, Examples.Resource.area_vertical_vl, Examples.Resource.bar_vl, Examples.Resource.bar_1d_vl,
            Examples.Resource.bar_1d_step_config_vl, Examples.Resource.bar_aggregate_vl, Examples.Resource.bar_aggregate_count_vl, Examples.Resource.bar_aggregate_format_vl,
            Examples.Resource.bar_aggregate_size_vl, Examples.Resource.bar_aggregate_sort_by_encoding_vl, Examples.Resource.bar_aggregate_sort_mean_vl, Examples.Resource.bar_aggregate_transform_vl,
            Examples.Resource.bar_aggregate_vertical_vl, Examples.Resource.bar_argmax_vl, Examples.Resource.bar_argmax_transform_vl, Examples.Resource.bar_array_aggregate_vl,
            Examples.Resource.bar_binned_data_vl, Examples.Resource.bar_color_disabled_scale_vl, Examples.Resource.bar_column_fold_vl, Examples.Resource.bar_column_pivot_vl,
            Examples.Resource.bar_count_minimap_vl, Examples.Resource.bar_custom_sort_full_vl, Examples.Resource.bar_custom_sort_partial_vl, Examples.Resource.bar_distinct_vl,
            Examples.Resource.bar_diverging_stack_population_pyramid_vl, Examples.Resource.bar_diverging_stack_transform_vl, Examples.Resource.bar_filter_calc_vl, Examples.Resource.bar_fit_vl,
            Examples.Resource.bar_gantt_vl, Examples.Resource.bar_grouped_vl, Examples.Resource.bar_grouped_horizontal_vl, Examples.Resource.bar_layered_transparent_vl,
            Examples.Resource.bar_layered_weather_vl, Examples.Resource.bar_month_vl, Examples.Resource.bar_month_band_vl, Examples.Resource.bar_month_band_config_vl,
            Examples.Resource.bar_month_temporal_vl, Examples.Resource.bar_month_temporal_initial_vl, Examples.Resource.bar_multi_values_per_categories_vl, Examples.Resource.bar_size_default_vl,
            Examples.Resource.bar_size_explicit_bad_vl, Examples.Resource.bar_size_fit_vl, Examples.Resource.bar_size_responsive_vl, Examples.Resource.bar_size_step_small_vl,
            Examples.Resource.bar_sort_by_count_vl, Examples.Resource.bar_swap_axes_vl, Examples.Resource.bar_swap_custom_vl, Examples.Resource.bar_title_vl, Examples.Resource.bar_title_start_vl,
            Examples.Resource.bar_tooltip_vl, Examples.Resource.bar_tooltip_multi_vl, Examples.Resource.bar_yearmonth_vl, Examples.Resource.bar_yearmonth_custom_format_vl,
            Examples.Resource.boxplot_1D_horizontal_vl, Examples.Resource.boxplot_1D_horizontal_custom_mark_vl, Examples.Resource.boxplot_1D_horizontal_explicit_vl,
            Examples.Resource.boxplot_1D_vertical_vl, Examples.Resource.boxplot_2D_horizontal_vl, Examples.Resource.boxplot_2D_horizontal_color_size_vl, Examples.Resource.boxplot_2D_vertical_vl,
            Examples.Resource.boxplot_minmax_2D_horizontal_vl, Examples.Resource.boxplot_minmax_2D_horizontal_custom_midtick_color_vl, Examples.Resource.boxplot_minmax_2D_vertical_vl,
            Examples.Resource.boxplot_tooltip_aggregate_vl, Examples.Resource.boxplot_tooltip_not_aggregate_vl, Examples.Resource.brush_table_vl, Examples.Resource.circle_vl,
            Examples.Resource.circle_binned_vl, Examples.Resource.circle_binned_maxbins_2_vl, Examples.Resource.circle_binned_maxbins_20_vl, Examples.Resource.circle_binned_maxbins_5_vl,
            Examples.Resource.circle_bubble_health_income_vl, Examples.Resource.circle_flatten_vl, Examples.Resource.circle_github_punchcard_vl, Examples.Resource.circle_natural_disasters_vl,
            Examples.Resource.circle_opacity_vl, Examples.Resource.circle_scale_quantile_vl, Examples.Resource.circle_scale_quantize_vl, Examples.Resource.circle_scale_threshold_vl,
            Examples.Resource.circle_wilkinson_dotplot_vl, Examples.Resource.circle_wilkinson_dotplot_stacked_vl, Examples.Resource.concat_bar_layer_circle_vl,
            Examples.Resource.concat_bar_scales_discretize_vl, Examples.Resource.concat_bar_scales_discretize_2_cols_vl, Examples.Resource.concat_hover_vl, Examples.Resource.concat_hover_filter_vl,
            Examples.Resource.concat_layer_voyager_result_vl, Examples.Resource.concat_marginal_histograms_vl, Examples.Resource.concat_population_pyramid_vl, Examples.Resource.concat_weather_vl,
            Examples.Resource.connected_scatterplot_vl, Examples.Resource.embedded_csv_vl, Examples.Resource.errorband_2d_horizontal_color_encoding_vl,
            Examples.Resource.errorband_2d_vertical_borders_vl, Examples.Resource.errorband_tooltip_vl, Examples.Resource.errorbar_2d_vertical_ticks_vl, Examples.Resource.errorbar_aggregate_vl,
            Examples.Resource.errorbar_horizontal_aggregate_vl, Examples.Resource.errorbar_tooltip_vl, Examples.Resource.facet_bullet_vl, Examples.Resource.facet_column_facet_column_point_future_vl,
            Examples.Resource.facet_column_facet_row_point_future_vl, Examples.Resource.facet_cross_independent_scale_vl, Examples.Resource.facet_custom_vl, Examples.Resource.facet_custom_header_vl,
            Examples.Resource.facet_independent_scale_vl, Examples.Resource.facet_independent_scale_layer_broken_vl, Examples.Resource.facet_row_facet_row_point_future_vl,
            Examples.Resource.geo_choropleth_vl, Examples.Resource.geo_circle_vl, Examples.Resource.geo_constant_value_vl, Examples.Resource.geo_custom_projection_vl,
            Examples.Resource.geo_graticule_vl, Examples.Resource.geo_graticule_object_vl, Examples.Resource.geo_layer_vl, Examples.Resource.geo_layer_line_london_vl,
            Examples.Resource.geo_layer_multi_vl, Examples.Resource.geo_line_vl, Examples.Resource.geo_point_vl, Examples.Resource.geo_repeat_vl, Examples.Resource.geo_rule_vl,
            Examples.Resource.geo_sphere_vl, Examples.Resource.geo_text_vl, Examples.Resource.geo_trellis_vl, Examples.Resource.hconcat_weather_vl, Examples.Resource.histogram_vl,
            Examples.Resource.histogram_bin_change_vl, Examples.Resource.histogram_bin_transform_vl, Examples.Resource.histogram_log_vl, Examples.Resource.histogram_no_spacing_vl,
            Examples.Resource.histogram_ordinal_vl, Examples.Resource.histogram_ordinal_sort_vl, Examples.Resource.interactive_area_brush_vl, Examples.Resource.interactive_bar_select_highlight_vl,
            Examples.Resource.interactive_bin_extent_vl, Examples.Resource.interactive_brush_vl, Examples.Resource.interactive_concat_layer_vl, Examples.Resource.interactive_dashboard_europe_pop_vl,
            Examples.Resource.interactive_index_chart_vl, Examples.Resource.interactive_layered_crossfilter_vl, Examples.Resource.interactive_layered_crossfilter_discrete_vl,
            Examples.Resource.interactive_legend_vl, Examples.Resource.interactive_legend_dblclick_vl, Examples.Resource.interactive_multi_line_label_vl,
            Examples.Resource.interactive_multi_line_pivot_tooltip_vl, Examples.Resource.interactive_multi_line_tooltip_vl, Examples.Resource.interactive_overview_detail_vl,
            Examples.Resource.interactive_paintbrush_vl, Examples.Resource.interactive_paintbrush_color_vl, Examples.Resource.interactive_paintbrush_color_nearest_vl,
            Examples.Resource.interactive_paintbrush_interval_vl, Examples.Resource.interactive_paintbrush_simple_all_vl, Examples.Resource.interactive_paintbrush_simple_none_vl,
            Examples.Resource.interactive_panzoom_splom_vl, Examples.Resource.interactive_panzoom_vconcat_shared_vl, Examples.Resource.interactive_query_widgets_vl,
            Examples.Resource.interactive_seattle_weather_vl, Examples.Resource.interactive_splom_vl, Examples.Resource.interactive_stocks_nearest_index_vl, Examples.Resource.isotype_bar_chart_vl,
            Examples.Resource.isotype_bar_chart_emoji_vl, Examples.Resource.isotype_grid_vl, Examples.Resource.joinaggregate_mean_difference_vl,
            Examples.Resource.joinaggregate_mean_difference_by_year_vl, Examples.Resource.joinaggregate_percent_of_total_vl, Examples.Resource.joinaggregate_residual_graph_vl,
            Examples.Resource.layer_bar_annotations_vl, Examples.Resource.layer_bar_labels_vl, Examples.Resource.layer_bar_labels_grey_vl, Examples.Resource.layer_bar_labels_style_vl,
            Examples.Resource.layer_bar_line_vl, Examples.Resource.layer_bar_line_union_vl, Examples.Resource.layer_bar_month_vl, Examples.Resource.layer_boxplot_circle_vl,
            Examples.Resource.layer_candlestick_vl, Examples.Resource.layer_circle_independent_color_vl, Examples.Resource.layer_color_legend_left_vl, Examples.Resource.layer_cumulative_histogram_vl,
            Examples.Resource.layer_dual_axis_vl, Examples.Resource.layer_falkensee_vl, Examples.Resource.layer_histogram_vl, Examples.Resource.layer_histogram_global_mean_vl,
            Examples.Resource.layer_likert_vl, Examples.Resource.layer_line_co2_concentration_vl, Examples.Resource.layer_line_color_rule_vl,
            Examples.Resource.layer_line_errorband_2d_horizontal_borders_strokedash_vl, Examples.Resource.layer_line_errorband_ci_vl, Examples.Resource.layer_line_errorband_pre_aggregated_vl,
            Examples.Resource.layer_line_mean_point_raw_vl, Examples.Resource.layer_line_rolling_mean_point_raw_vl, Examples.Resource.layer_line_window_vl, Examples.Resource.layer_overlay_vl,
            Examples.Resource.layer_point_errorbar_1d_horizontal_vl, Examples.Resource.layer_point_errorbar_1d_vertical_vl, Examples.Resource.layer_point_errorbar_2d_horizontal_vl,
            Examples.Resource.layer_point_errorbar_2d_horizontal_ci_vl, Examples.Resource.layer_point_errorbar_2d_horizontal_color_encoding_vl,
            Examples.Resource.layer_point_errorbar_2d_horizontal_custom_ticks_vl, Examples.Resource.layer_point_errorbar_2d_horizontal_iqr_vl,
            Examples.Resource.layer_point_errorbar_2d_horizontal_stdev_vl, Examples.Resource.layer_point_errorbar_2d_vertical_vl, Examples.Resource.layer_point_errorbar_ci_vl,
            Examples.Resource.layer_point_errorbar_pre_aggregated_asymmetric_error_vl, Examples.Resource.layer_point_errorbar_pre_aggregated_symmetric_error_vl,
            Examples.Resource.layer_point_errorbar_pre_aggregated_upper_lower_vl, Examples.Resource.layer_point_errorbar_stdev_vl, Examples.Resource.layer_point_line_loess_vl,
            Examples.Resource.layer_point_line_regression_vl, Examples.Resource.layer_precipitation_mean_vl, Examples.Resource.layer_ranged_dot_vl, Examples.Resource.layer_rect_extent_vl,
            Examples.Resource.layer_scatter_errorband_1d_stdev_vl, Examples.Resource.layer_scatter_errorband_1D_stdev_global_mean_vl, Examples.Resource.layer_single_color_vl,
            Examples.Resource.layer_text_heatmap_vl, Examples.Resource.line_vl, Examples.Resource.line_calculate_vl, Examples.Resource.line_color_vl, Examples.Resource.line_color_binned_vl,
            Examples.Resource.line_conditional_grid_dash_vl, Examples.Resource.line_detail_vl, Examples.Resource.line_encoding_impute_keyvals_vl,
            Examples.Resource.line_encoding_impute_keyvals_sequence_vl, Examples.Resource.line_impute_frame_vl, Examples.Resource.line_impute_keyvals_vl, Examples.Resource.line_impute_method_vl,
            Examples.Resource.line_impute_transform_frame_vl, Examples.Resource.line_impute_transform_value_vl, Examples.Resource.line_impute_value_vl,
            Examples.Resource.line_inside_domain_using_clip_vl, Examples.Resource.line_inside_domain_using_transform_vl, Examples.Resource.line_max_year_vl, Examples.Resource.line_mean_month_vl,
            Examples.Resource.line_mean_year_vl, Examples.Resource.line_monotone_vl, Examples.Resource.line_month_vl, Examples.Resource.line_month_center_band_vl,
            Examples.Resource.line_outside_domain_vl, Examples.Resource.line_overlay_vl, Examples.Resource.line_overlay_stroked_vl, Examples.Resource.line_quarter_legend_vl,
            Examples.Resource.line_shape_overlay_vl, Examples.Resource.line_skip_invalid_vl, Examples.Resource.line_skip_invalid_mid_vl, Examples.Resource.line_skip_invalid_mid_cap_square_vl,
            Examples.Resource.line_skip_invalid_mid_overlay_vl, Examples.Resource.line_slope_vl, Examples.Resource.line_sort_axis_vl, Examples.Resource.line_step_vl,
            Examples.Resource.line_timeunit_transform_vl, Examples.Resource.lookup_vl, Examples.Resource.nested_concat_align_vl, Examples.Resource.parallel_coordinate_vl,
            Examples.Resource.point_1d_vl, Examples.Resource.point_1d_array_vl, Examples.Resource.point_2d_vl, Examples.Resource.point_2d_aggregate_vl, Examples.Resource.point_2d_array_vl,
            Examples.Resource.point_2d_array_named_vl, Examples.Resource.point_2d_tooltip_vl, Examples.Resource.point_2d_tooltip_data_vl, Examples.Resource.point_aggregate_detail_vl,
            Examples.Resource.point_background_vl, Examples.Resource.point_binned_color_vl, Examples.Resource.point_binned_opacity_vl, Examples.Resource.point_binned_size_vl,
            Examples.Resource.point_bubble_vl, Examples.Resource.point_color_vl, Examples.Resource.point_colorramp_size_vl, Examples.Resource.point_color_custom_vl,
            Examples.Resource.point_color_ordinal_vl, Examples.Resource.point_color_quantitative_vl, Examples.Resource.point_color_shape_constant_vl, Examples.Resource.point_color_with_shape_vl,
            Examples.Resource.point_diverging_color_vl, Examples.Resource.point_dot_timeunit_color_vl, Examples.Resource.point_filled_vl, Examples.Resource.point_href_vl,
            Examples.Resource.point_invalid_color_vl, Examples.Resource.point_log_vl, Examples.Resource.point_no_axis_domain_grid_vl, Examples.Resource.point_ordinal_color_vl,
            Examples.Resource.point_overlap_vl, Examples.Resource.point_quantile_quantile_vl, Examples.Resource.point_shape_custom_vl, Examples.Resource.point_tooltip_vl,
            Examples.Resource.rect_binned_heatmap_vl, Examples.Resource.rect_heatmap_vl, Examples.Resource.rect_heatmap_weather_vl, Examples.Resource.rect_lasagna_vl,
            Examples.Resource.rect_mosaic_labelled_vl, Examples.Resource.rect_mosaic_labelled_with_offset_vl, Examples.Resource.rect_mosaic_simple_vl, Examples.Resource.repeat_histogram_vl,
            Examples.Resource.repeat_histogram_flights_vl, Examples.Resource.repeat_independent_colors_vl, Examples.Resource.repeat_layer_vl, Examples.Resource.repeat_line_weather_vl,
            Examples.Resource.repeat_splom_cars_vl, Examples.Resource.repeat_splom_iris_vl, Examples.Resource.rule_color_mean_vl, Examples.Resource.rule_extent_vl,
            Examples.Resource.sample_scatterplot_vl, Examples.Resource.scatter_image_vl, Examples.Resource.selection_bind_cylyr_vl, Examples.Resource.selection_bind_origin_vl,
            Examples.Resource.selection_brush_timeunit_vl, Examples.Resource.selection_clear_brush_vl, Examples.Resource.selection_composition_and_vl, Examples.Resource.selection_composition_or_vl,
            Examples.Resource.selection_concat_vl, Examples.Resource.selection_filter_vl, Examples.Resource.selection_filter_composition_vl, Examples.Resource.selection_heatmap_vl,
            Examples.Resource.selection_insert_vl, Examples.Resource.selection_interval_mark_style_vl, Examples.Resource.selection_layer, Examples.Resource.selection_layer_bar_month_vl,
            Examples.Resource.selection_multi_condition_vl, Examples.Resource.selection_project_binned_interval_vl, Examples.Resource.selection_project_interval_vl,
            Examples.Resource.selection_project_interval_x_vl, Examples.Resource.selection_project_interval_x_y_vl, Examples.Resource.selection_project_interval_y_vl,
            Examples.Resource.selection_project_multi_vl, Examples.Resource.selection_project_multi_cylinders_vl, Examples.Resource.selection_project_multi_cylinders_origin_vl,
            Examples.Resource.selection_project_multi_origin_vl, Examples.Resource.selection_project_single_vl, Examples.Resource.selection_project_single_cylinders_vl,
            Examples.Resource.selection_project_single_cylinders_origin_vl, Examples.Resource.selection_project_single_origin_vl, Examples.Resource.selection_resolution_global_vl,
            Examples.Resource.selection_resolution_intersect_vl, Examples.Resource.selection_resolution_union_vl, Examples.Resource.selection_toggle_altKey_vl,
            Examples.Resource.selection_toggle_altKey_shiftKey_vl, Examples.Resource.selection_toggle_shiftKey_vl, Examples.Resource.selection_translate_brush_drag_vl,
            Examples.Resource.selection_translate_brush_shift_drag_vl, Examples.Resource.selection_translate_scatterplot_drag_vl, Examples.Resource.selection_translate_scatterplot_shift_drag_vl,
            Examples.Resource.selection_type_interval_vl, Examples.Resource.selection_type_interval_invert_vl, Examples.Resource.selection_type_multi_vl, Examples.Resource.selection_type_single_vl,
            Examples.Resource.selection_type_single_dblclick_vl, Examples.Resource.selection_type_single_mouseover_vl, Examples.Resource.selection_zoom_brush_shift_wheel_vl,
            Examples.Resource.selection_zoom_brush_wheel_vl, Examples.Resource.selection_zoom_scatterplot_shift_wheel_vl, Examples.Resource.selection_zoom_scatterplot_wheel_vl,
            Examples.Resource.sequence_line_vl, Examples.Resource.sequence_line_fold_vl, Examples.Resource.square_vl, Examples.Resource.stacked_area_vl, Examples.Resource.stacked_area_normalize_vl,
            Examples.Resource.stacked_area_ordinal_vl, Examples.Resource.stacked_area_overlay_vl, Examples.Resource.stacked_area_stream_vl, Examples.Resource.stacked_bar_1d_vl,
            Examples.Resource.stacked_bar_count_vl, Examples.Resource.stacked_bar_count_corner_radius_config_vl, Examples.Resource.stacked_bar_count_corner_radius_mark_vl,
            Examples.Resource.stacked_bar_count_corner_radius_mark_x_vl, Examples.Resource.stacked_bar_count_corner_radius_stroke_vl, Examples.Resource.stacked_bar_h_vl,
            Examples.Resource.stacked_bar_h_order_vl, Examples.Resource.stacked_bar_h_order_custom_vl, Examples.Resource.stacked_bar_normalize_vl, Examples.Resource.stacked_bar_population_vl,
            Examples.Resource.stacked_bar_population_transform_vl, Examples.Resource.stacked_bar_size_vl, Examples.Resource.stacked_bar_sum_opacity_vl, Examples.Resource.stacked_bar_unaggregate_vl,
            Examples.Resource.stacked_bar_v_vl, Examples.Resource.stacked_bar_weather_vl, Examples.Resource.test_aggregate_nested_vl, Examples.Resource.test_field_with_spaces_vl,
            Examples.Resource.test_minimal, Examples.Resource.test_single_point_color_vl, Examples.Resource.test_subobject_vl, Examples.Resource.test_subobject_missing_vl,
            Examples.Resource.test_subobject_nested_vl, Examples.Resource.text_format_vl, Examples.Resource.text_scatterplot_colored_vl, Examples.Resource.tick_dot_vl,
            Examples.Resource.tick_dot_thickness_vl, Examples.Resource.tick_sort_vl, Examples.Resource.tick_strip_vl, Examples.Resource.time_output_utc_scale_vl,
            Examples.Resource.time_output_utc_timeunit_vl, Examples.Resource.time_parse_local_vl, Examples.Resource.time_parse_utc_vl, Examples.Resource.time_parse_utc_format_vl,
            Examples.Resource.trail_color_vl, Examples.Resource.trellis_anscombe_vl, Examples.Resource.trellis_area_vl, Examples.Resource.trellis_area_sort_array_vl, Examples.Resource.trellis_bar_vl,
            Examples.Resource.trellis_barley_vl, Examples.Resource.trellis_barley_independent_vl, Examples.Resource.trellis_barley_layer_median_vl, Examples.Resource.trellis_bar_histogram_vl,
            Examples.Resource.trellis_bar_histogram_label_rotated_vl, Examples.Resource.trellis_column_year_vl, Examples.Resource.trellis_cross_sort_vl, Examples.Resource.trellis_cross_sort_array_vl,
            Examples.Resource.trellis_line_quarter_vl, Examples.Resource.trellis_row_column_vl, Examples.Resource.trellis_scatter_vl, Examples.Resource.trellis_scatter_binned_row_vl,
            Examples.Resource.trellis_scatter_small_vl, Examples.Resource.trellis_selections_vl, Examples.Resource.trellis_stacked_bar_vl, Examples.Resource.vconcat_flatten_vl,
            Examples.Resource.vconcat_weather_vl, Examples.Resource.waterfall_chart_vl, Examples.Resource.wheat_wages_vl, Examples.Resource.window_cumulative_running_average_vl,
            Examples.Resource.window_percent_of_total_vl, Examples.Resource.window_rank_vl, Examples.Resource.window_top_k_vl, Examples.Resource.window_top_k_others_vl
        };
    }
}
