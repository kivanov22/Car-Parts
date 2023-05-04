import React from "react";
import { Carousel } from "react-responsive-carousel";
import "react-responsive-carousel/lib/styles/carousel.min.css";
import "./Banner.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faSearch } from "@fortawesome/free-solid-svg-icons";
import { useSearchParams } from "react-router-dom";
// import {car1} from "../../../public/images/audi.jpg"

const Banner = () => {
//   const [search, setSearch] = useSearchParams();

//   const handleSearch = (e) => {
//     setSearch();
//   };

  return (
    <div className="banner">
      <div className="container">
        <Carousel
          autoPlay
          infiniteLoop
          showStatus={false}
          showThumbs={false}
          interval={5000}
        >
          <div className="darkerImg">
            <img src="./images/audi.jpg" alt="img" />
          </div>
          <div className="darkerImg">
            <img src="./images/mercedes.jpg" alt="img" />
          </div>
          <div className="darkerImg">
            <img src="./images/mercedes2.jpg" alt="img" />
          </div>
        </Carousel>
        <div className="search">
          <label htmlFor="make">Make</label>
          <select name="make" id="make">
            <option value="opel">Opel</option>
            <option value="Audi">Audi</option>
            <option value="BMW">BMW</option>
            <option value="Mercedes">Mercedes</option>
          </select>
          <label htmlFor="model">Model</label>
          <select name="model" id="model">
            <option value="opel">Opel</option>
            <option value="Audi">Audi</option>
            <option value="BMW">BMW</option>
            <option value="Mercedes">Mercedes</option>
          </select>
          <label htmlFor="specification">Specification</label>
          <select name="specification" id="specification">
            <option value="opel">Opel</option>
            <option value="Audi">Audi</option>
            <option value="BMW">BMW</option>
            <option value="Mercedes">Mercedes</option>
          </select>
          <button>
            <FontAwesomeIcon icon={faSearch} />
            Search
          </button>
        </div>
      </div>
    </div>
  );
};

export default Banner;
