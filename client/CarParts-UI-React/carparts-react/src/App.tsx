import './App.scss';
import Banner from './components/Banner/Banner';
import Brand from './components/Brands/Brand';
import Category from './components/Categories/Category';
import Footer from './components/Footer/Footer';
import Navbar from './components/Navigation/Navbar';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import Catalog from './pages/CatalogParts/Catalog';
import Register from './pages/Register/Register';
import Login from './pages/Login/Login';

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
