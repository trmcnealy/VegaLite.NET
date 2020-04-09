
#include <arrow/api.h>
#include <arrow/table.h>
#include <arrow/io/api.h>
#include <arrow/csv/converter.h>
#include <arrow/csv/test_common.h>
#include <arrow/filesystem/api.h>
#include <arrow/ipc/reader.h>
#include <arrow/csv/options.h>
#include <arrow/io/interfaces.h>
#include <arrow/ipc/writer.h>
#include <arrow/csv/reader.h>
#include <arrow/util/compression_zlib.h>

#include <iostream>

//#include <arrow/util/compression_zlib.h>

template<class T>
__inline static std::shared_ptr<T> buildArray(const std::shared_ptr<arrow::Table>& table, const std::string& name)
{
    arrow::MemoryPool*            pool = arrow::default_memory_pool();
    std::shared_ptr<arrow::Array> _array;
    arrow::Concatenate(table->GetColumnByName(name)->chunks(), pool, &_array);
    std::shared_ptr<T> type_array = std::static_pointer_cast<T>(_array);
    return type_array;
}

int main(int argc, char* argv[])
{
    arrow::Status st;

    arrow::MemoryPool* pool = arrow::default_memory_pool();

    std::shared_ptr<arrow::io::InputStream> input;

    st = arrow::io::ReadableFile::Open("C:/Users/tehgo/Desktop/PSO.csv").Value(&input);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    arrow::csv::ReadOptions read_options = arrow::csv::ReadOptions::Defaults();
    {
        read_options.skip_rows = 1;
        read_options.column_names.push_back("Iteration");
        read_options.column_names.push_back("SwarmIndex");
        read_options.column_names.push_back("Particle");
        read_options.column_names.push_back("Particle0Position");
        read_options.column_names.push_back("Particle0Velocity");
        read_options.column_names.push_back("Particle0Residual");
        read_options.column_names.push_back("Particle1Position");
        read_options.column_names.push_back("Particle1Velocity");
        read_options.column_names.push_back("Particle1Residual");
        read_options.column_names.push_back("Particle2Position");
        read_options.column_names.push_back("Particle2Velocity");
        read_options.column_names.push_back("Particle2Residual");
        read_options.column_names.push_back("Particle3Position");
        read_options.column_names.push_back("Particle3Velocity");
        read_options.column_names.push_back("Particle3Residual");
        read_options.column_names.push_back("Particle4Position");
        read_options.column_names.push_back("Particle4Velocity");
        read_options.column_names.push_back("Particle4Residual");
        read_options.column_names.push_back("Particle5Position");
        read_options.column_names.push_back("Particle5Velocity");
        read_options.column_names.push_back("Particle5Residual");
        read_options.column_names.push_back("Particle6Position");
        read_options.column_names.push_back("Particle6Velocity");
        read_options.column_names.push_back("Particle6Residual");
    }

    arrow::csv::ParseOptions parse_options = arrow::csv::ParseOptions::Defaults();

    arrow::csv::ConvertOptions convert_options = arrow::csv::ConvertOptions::Defaults();
    {
        convert_options.column_types["Iteration"]         = arrow::uint32();
        convert_options.column_types["SwarmIndex"]        = arrow::uint32();
        convert_options.column_types["Particle"]          = arrow::uint32();
        convert_options.column_types["Particle0Position"] = arrow::float32();
        convert_options.column_types["Particle0Velocity"] = arrow::float32();
        convert_options.column_types["Particle0Residual"] = arrow::float32();
        convert_options.column_types["Particle1Position"] = arrow::float32();
        convert_options.column_types["Particle1Velocity"] = arrow::float32();        
        convert_options.column_types["Particle1Residual"] = arrow::float32();
        convert_options.column_types["Particle2Position"] = arrow::float32();
        convert_options.column_types["Particle2Velocity"] = arrow::float32();
        convert_options.column_types["Particle2Residual"] = arrow::float32();
        convert_options.column_types["Particle3Position"] = arrow::float32();
        convert_options.column_types["Particle3Velocity"] = arrow::float32();
        convert_options.column_types["Particle3Residual"] = arrow::float32();
        convert_options.column_types["Particle4Position"] = arrow::float32();
        convert_options.column_types["Particle4Velocity"] = arrow::float32();
        convert_options.column_types["Particle4Residual"] = arrow::float32();
        convert_options.column_types["Particle5Position"] = arrow::float32();
        convert_options.column_types["Particle5Velocity"] = arrow::float32();
        convert_options.column_types["Particle5Residual"] = arrow::float32();
        convert_options.column_types["Particle6Position"] = arrow::float32();
        convert_options.column_types["Particle6Velocity"] = arrow::float32();
        convert_options.column_types["Particle6Residual"] = arrow::float32();

        convert_options.include_columns = {"Iteration",
                                           "SwarmIndex",
                                           "Particle",
                                           "Particle0Position",
                                           "Particle0Velocity",
                                           "Particle0Residual",
                                           "Particle1Position",
                                           "Particle1Velocity",
                                           "Particle1Residual",
                                           "Particle2Position",
                                           "Particle2Velocity",
                                           "Particle2Residual",
                                           "Particle3Position",
                                           "Particle3Velocity",
                                           "Particle3Residual",
                                           "Particle4Position",
                                           "Particle4Velocity",
                                           "Particle4Residual",
                                           "Particle5Position",
                                           "Particle5Velocity",
                                           "Particle5Residual",
                                           "Particle6Position",
                                           "Particle6Velocity",
                                           "Particle6Residual"};
    }

    std::shared_ptr<arrow::csv::TableReader> reader;
    st = arrow::csv::TableReader::Make(pool, input, read_options, parse_options, convert_options).Value(&reader);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    std::shared_ptr<arrow::Table> table;

    st = reader->Read().Value(&table);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    input->Close();

    //###############################################################################################################
    //
    // std::cout << "table->num_rows()" << table->num_rows() << std::endl;
    //
    // for (std::string column_name : table->ColumnNames())
    //{
    //    std::cout << column_name << std::endl;
    //}
    //
    //
    // std::shared_ptr<arrow::ChunkedArray> Particle5Position = table->GetColumnByName("Particle5Position");
    //
    // std::cout << Particle5Position->type() << std::endl;
    //
    //
    // std::shared_ptr<arrow::FloatArray> float_array = std::static_pointer_cast<arrow::FloatArray>(Particle5Position->chunk(0));
    //
    //
    //
    // std::cout << "Particle5Position->chunks()[0] " << float_array->Value(0) << std::endl;
    //
    //###############################################################################################################

    auto schema = arrow::schema({
        arrow::field("Iteration", arrow::uint32()),
        arrow::field("SwarmIndex", arrow::uint32()),
        arrow::field("Particle", arrow::uint32()),
        arrow::field("Particle0Position", arrow::float32()),
        arrow::field("Particle0Residual", arrow::float32()),
        // arrow::field("Particle0Velocity",  arrow::float32()),
        arrow::field("Particle1Position", arrow::float32()),
        arrow::field("Particle1Residual", arrow::float32()),
        // arrow::field("Particle1Velocity",  arrow::float32()),
        arrow::field("Particle2Position", arrow::float32()),
        arrow::field("Particle2Residual", arrow::float32()),
        // arrow::field("Particle2Velocity",  arrow::float32()),
        arrow::field("Particle3Position", arrow::float32()),
        arrow::field("Particle3Residual", arrow::float32()),
        // arrow::field("Particle3Velocity",  arrow::float32()),
        arrow::field("Particle4Position", arrow::float32()),
        arrow::field("Particle4Residual", arrow::float32()),
        // arrow::field("Particle4Velocity",  arrow::float32()),
        arrow::field("Particle5Position", arrow::float32()),
        arrow::field("Particle5Residual", arrow::float32()),
        // arrow::field("Particle5Velocity",  arrow::float32()),
        // arrow::field("Particle6Position",  arrow::float32()),
        // arrow::field("Particle6Velocity",  arrow::float32())
    });

    auto Iteration_array         = buildArray<arrow::UInt32Array>(table, "Iteration");
    auto SwarmIndex_array        = buildArray<arrow::UInt32Array>(table, "SwarmIndex");
    auto Particle_array          = buildArray<arrow::UInt32Array>(table, "Particle");
    auto Particle0Position_array = buildArray<arrow::FloatArray>(table, "Particle0Position");
    auto Particle0Residual_array = buildArray<arrow::FloatArray>(table, "Particle0Residual");
    auto Particle1Position_array = buildArray<arrow::FloatArray>(table, "Particle1Position");
    auto Particle1Residual_array = buildArray<arrow::FloatArray>(table, "Particle1Residual");
    auto Particle2Position_array = buildArray<arrow::FloatArray>(table, "Particle2Position");
    auto Particle2Residual_array = buildArray<arrow::FloatArray>(table, "Particle2Residual");
    auto Particle3Position_array = buildArray<arrow::FloatArray>(table, "Particle3Position");
    auto Particle3Residual_array = buildArray<arrow::FloatArray>(table, "Particle3Residual");
    auto Particle4Position_array = buildArray<arrow::FloatArray>(table, "Particle4Position");
    auto Particle4Residual_array = buildArray<arrow::FloatArray>(table, "Particle4Residual");
    auto Particle5Position_array = buildArray<arrow::FloatArray>(table, "Particle5Position");
    auto Particle5Residual_array = buildArray<arrow::FloatArray>(table, "Particle5Residual");

    auto data_table = arrow::Table::Make(schema,
                                         {Iteration_array,
                                          SwarmIndex_array,
                                          Particle_array,
                                          Particle0Position_array, Particle0Residual_array,
                                          Particle1Position_array, Particle1Residual_array,
                                          Particle2Position_array, Particle2Residual_array,
                                          Particle3Position_array, Particle3Residual_array,
                                          Particle4Position_array, Particle4Residual_array,
                                          Particle5Position_array, Particle5Residual_array});

    std::cout << data_table->GetColumnByName("Particle0Position")->num_chunks() << std::endl;

    std::cout << "Particle0Position_array " << Particle0Position_array->Value(0) << std::endl;

    std::shared_ptr<arrow::io::FileOutputStream> output;
    st = arrow::io::FileOutputStream::Open("C:/Users/tehgo/Desktop/PSO.arrow").Value(&output);
    //st = arrow::io::CompressedOutputStream::Make(new arrow::util::GZipCodec(), output).Value(&output);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    // table->RemoveColumn(16, &table);
    // table->RemoveColumn(15, &table);
    // table->RemoveColumn(14, &table);
    // table->RemoveColumn(12, &table);
    // table->RemoveColumn(10, &table);
    // table->RemoveColumn(8, &table);
    // table->RemoveColumn(6, &table);

    st = data_table->ValidateFull();

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    arrow::ipc::IpcWriteOptions write_options = arrow::ipc::IpcWriteOptions::Defaults();
    //write_options.compression = arrow::Compression::GZIP;
    //write_options.compression_level = 2;

    std::shared_ptr<arrow::ipc::RecordBatchWriter> writer;
    st = arrow::ipc::NewFileWriter(output.get(), data_table->schema(), write_options).Value(&writer);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    st = writer->WriteTable(*data_table);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    writer->Close();

    output->Close();

    //###############################################################################################################

    std::shared_ptr<arrow::io::ReadableFile> input_arrow;

    st = arrow::io::ReadableFile::Open("C:/Users/tehgo/Desktop/PSO.arrow").Value(&input_arrow);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    arrow::ipc::IpcReadOptions read_arrow_options = arrow::ipc::IpcReadOptions::Defaults();

     std::shared_ptr<arrow::ipc::RecordBatchFileReader> reader_arrow;

     st = arrow::ipc::RecordBatchFileReader::Open(input_arrow.get(), read_arrow_options).Value(&reader_arrow);

    if(!st.ok())
    {
        std::cout << st.message() << std::endl;
    }

    std::cout << "reader_arrow->num_record_batches()" << reader_arrow->num_record_batches() << std::endl;

    std::cout << "Press any key to exit." << std::endl;
    getchar();

    return 0;
}
