import "./Catalog.scss";
import Navbar from "../../components/Shared/navigation/Navbar";
import Footer from "../../components/Shared/footer/Footer";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBorderAll, faBars } from "@fortawesome/free-solid-svg-icons";
import CatalogCard from "../../components/Parts/CatalogCard/CatalogCard";

const Catalog = () => {
  return (
    <div className="catalog">
      <Navbar />
      {/* Banner */}
      {/* left part */}
      <div className="leftCatalog">
        <div className="categoriesVehicle">
          <input type="text" placeholder="make" />
          <input type="text" placeholder="model" />
          <input type="text" placeholder="year" />
          <input type="text" placeholder="body type" />
        </div>
        <div className="categoriesFilter">
          <p>Categories</p>
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
        <div className="categoriesPrice"></div>
        <div className="categoriesAvailable"></div>
      </div>
      {/* right part */}
      <div className="rightCatalog">
        <div className="sort">
          <p>Showing 1–16 of 37 results</p>
          <label htmlFor="">Sort</label>
          <select name="" id="">
            <option value="">Price low to high</option>
            <option value="">Price high to low</option>
            <option value="">Sort by Latest</option>
            <option value="">Sort by popularity</option>
          </select>
          <label htmlFor="">Show</label>
          <FontAwesomeIcon icon={faBorderAll} />
          <FontAwesomeIcon icon={faBars} />

        </div>
          <div className="catalogCards">
            <CatalogCard />
            <CatalogCard />
            <CatalogCard />
            <CatalogCard />
            <CatalogCard />
          </div>
      </div>
      <Footer />
    </div>
  );
};

export default Catalog;
