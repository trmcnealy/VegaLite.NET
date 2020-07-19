
#include <eigen.hpp>
#include <iostream>

using namespace Eigen;

template<typename T>
void test()
{
    const size_type rows  = internal::random<size_type>(1, 64);
    const size_type cols  = internal::random<size_type>(1, 64);
    const size_type depth = internal::random<size_type>(1, 65);

    MatrixKokkos<T> A = EigenMatrix<T, Kokkos::Cuda>(rows, depth);
    A.setRandom();

    MatrixKokkos<T> B = EigenMatrix<T, Kokkos::Cuda>(depth, cols);
    B.setRandom();

    MatrixKokkos<T> C = EigenMatrix<T, Kokkos::Cuda>(rows, cols);
    C.setRandom();

    MatrixKokkos<T> D = EigenMatrix<T, Kokkos::Cuda>(rows, cols);


    Kokkos::MDRangePolicy<Kokkos::Cuda, Kokkos::Rank<2>, Kokkos::IndexType<Index>> range({0, 0}, {C.rows(), C.cols()});

    Kokkos::parallel_for(range, [=] __host__ __device__(const Index i, const Index j) {

        for(Index k = 0; k < A.cols(); ++k)
        {
            D.at(i, j) += A.coeff(i, k) * B.coeff(k, j);
        }

        //const T value = D.coeffRef(i, j) + (A.coeff(i, k) * B.coeff(k, j));
        //Kokkos::atomic_exchange(&D.coeffRef(i, j), value);
    });

    //for(Index i = 0; i < C.rows(); ++i)
    //{
    //    for(Index j = 0; j < C.cols(); ++j)
    //    {
    //        for(Index k = 0; k < A.cols(); ++k)
    //        {
    //            D.coeffRef(i, j) += A.coeff(i, k) * B.coeff(k, j);
    //        }
    //    }
    //}

    C += A * B;

    if(C != D)
    {
        std::cout << "C!=D" << std::endl;

        //for(Index i = 0; i < C.rows(); ++i)
        //{
        //    for(Index j = 0; j < C.cols(); ++j)
        //    {
        //        for(Index k = 0; k < A.cols(); ++k)
        //        {
        //            std::cout << D.coeffRef(i, j) << std::endl;
        //        }
        //    }
        //}
    }

    ////MatrixKokkos<T> E = B.transpose();

    ////for(Index i = 0; i < B.rows(); ++i)
    ////{
    ////    for(Index j = 0; j < B.cols(); ++j)
    ////    {
    ////        if(B(i, j) != E(j, i))
    ////        {
    ////            std::cout << "B(i, j)!=E(j, i)" << std::endl;
    ////        }
    ////    }
    ////}
}

int main(int argc, char* argv[])
{
    Kokkos::initialize(argc, argv);

    test<double>();

    Kokkos::finalize();

    return 0;
}
