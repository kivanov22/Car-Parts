import "./Catalog.scss";
import Navbar from "../../components/Shared/navigation/Navbar";
import Footer from "../../components/Shared/footer/Footer";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBorderAll, faBars } from "@fortawesome/free-solid-svg-icons";
import CatalogCard from "../../components/Parts/CatalogCard/CatalogCard";
import FilterBar from "../../components/filter/FilterBar";

const Catalog = () => {
  return (
    <div className="catalog-page">
      <Navbar />
      <div className="content">
        <div className="sidebar">
          <FilterBar />
        </div>

        <div className="catalog">
          <div className="catalog-list">
            <div className="sort-options">
              <label htmlFor="sortBy">Sort By:</label>
              <select id="sortBy">
                <option value="price">Price</option>
                {/* Add more sorting options as needed */}
              </select>
            </div>
            <div className="part-grid">
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              <div className="part">
                <CatalogCard />
              </div>
              {/* Render your parts catalog here */}
            </div>
          </div>
        </div>
      </div>

      <Footer />
    </div>
  );
};

export default Catalog;

{
  /* <div className="sort">
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
          </div> */
}
