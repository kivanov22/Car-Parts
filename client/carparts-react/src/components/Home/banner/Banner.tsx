import React from "react";
import { Carousel } from "react-responsive-carousel";
import "react-responsive-carousel/lib/styles/carousel.min.css";
import "./Banner.scss";

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
       
      </div>
    </div>
  );
};

export default Banner;
