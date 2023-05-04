import "./App.scss";
import Banner from "./components/banner/Banner";
import Brand from "./components/brands/Brand";
import Category from "./components/categories/Category";
import Footer from "./components/footer/Footer";
import Navbar from "./components/navigation/Navbar";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import { Component, lazy, Suspense } from "react";
import LoadingSpinner from "./components/spinner/LoadingSpinner";
import Part from "./components/part/Part";

function App() {
  const fakeDelay = async(promise:any)=>{
    return new Promise((resolve)=>{
      setTimeout(resolve,3000);
    }).then(()=>promise);
  }


  const Loadable = (Component: any) => (props: JSX.IntrinsicAttributes) =>
    (
      <Suspense fallback={<LoadingSpinner />}>
        <Component {...props} />
      </Suspense>
    );

  const Login = Loadable(lazy(() => fakeDelay(import("./pages/login/Login"))));
  const Register = Loadable(lazy(() => fakeDelay(import("./pages/register/Register"))));
  const Catalog = Loadable(lazy(() => import("./pages/catalogParts/Catalog")));



  const Layout = () => {
    return (
      <div className="App">
        <Navbar />
        <hr />
        <Banner />
        <Part />
        <Category />
        <Brand />
        <Footer />
      </div>
    );
  };

  const router = createBrowserRouter([
    {
      path: "/",
      element: <Layout />,
      children: [
        // {
        //   path: "/",
        //   element: <Home />,
        // },
      ],
    },
    {
      path: "/catalog",
      element: <Catalog />,
    },
    {
      path: "/register",
      element: <Register />,
    },
    {
      path: "/login",
      element: <Login />,
    },
  ]);

  return <RouterProvider router={router} />;
}

export default App;
