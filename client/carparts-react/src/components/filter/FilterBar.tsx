import React from "react";
import "./FilterBar.scss";

const FilterBar = () => {
  return (
    <div className="sidebar">
      <h2>Filters</h2>

      {/* Make dropdown */}
      <label htmlFor="make">Make:</label>
      <select name="make" id="make">
        {/* Add options here */}
      </select>

      {/* Model dropdown */}
      <label htmlFor="model">Model:</label>
      <select name="model" id="model">
        {/* Add options here */}
      </select>

      {/* Price range slider */}
      <label htmlFor="price">Price Range:</label>
      <input type="range" name="price" id="price" />

      {/* Additional feature checkboxes */}
      <label>Additional Features:</label>
      <div className="checkboxes">
        {/* Add checkboxes here */}
      </div>

      {/* Apply button */}
      <button>Apply Filters</button>
    </div>
  );
};

export default FilterBar;

{/* <div className="filter-sidebar">
      <div className="carSpecificsFilter">
        <div className="carSpecificsSelect">
          <label htmlFor="">Car Make</label>
          <select name="" id="">
            <option value="">Mercedes</option>
            <option value="">BMW</option>
            <option value="">Opel</option>
          </select>
        </div>
        <div className="carSpecificsSelect">
          <label htmlFor="">Car Model</label>
          <select name="" id="">
            <option value="">X7</option>
            <option value="">Q7</option>
            <option value="">Insignia</option>
          </select>
        </div>
        <input
          type="text"
          placeholder="year"
          className="inputCategoryVehicle"
        />
        <input
          type="text"
          placeholder="body type"
          className="inputCategoryVehicle"
        />
      </div>
      <div className="categoriesFilter">
        <p>Categories</p>
        <div className="checkItems">
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
        <div className="checkItems">
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
        <div className="checkItems">
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
        <div className="checkItems">
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
        <div className="checkItems">
          <input type="checkbox" />
          <label htmlFor="">Tires</label>
        </div>
      </div>
      <div className="categoriesPrice">
        <label htmlFor="">Price</label>
        <input type="number" placeholder="enter a start price"/>
        <input type="number" placeholder="enter a end price"/>
      </div>
      <div className="categoriesAvailable">

      </div>
    </div> */}