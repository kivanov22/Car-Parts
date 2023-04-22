import './App.scss';
import Banner from './components/banner/Banner';
import Brand from './components/brands/Brand';
import Category from './components/categories/Category';
import Footer from './components/footer/Footer';
import Navbar from './components/navigation/Navbar';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import Catalog from './pages/catalogParts/Catalog';
import Register from './pages/register/Register';
import Login from './pages/login/Login';

function App() {
  const Layout =()=>{
    return (
      <div className="App">
      <Navbar />
      <hr />
      <Banner />
      <Category />
      <Brand />
      <Footer />
     </div>
    )
  }

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
      path:"/catalog",
      element :<Catalog />
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
