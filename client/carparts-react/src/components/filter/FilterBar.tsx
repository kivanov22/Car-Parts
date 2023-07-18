import React from "react";
import "./FilterBar.scss";

const FilterBar = () => {
  return (
    <div className="filter-sidebar">
      <div className="carSpecificsFilter">
        <input
          type="text"
          placeholder="make"
          className="inputCategoryVehicle"
        />
        <input
          type="text"
          placeholder="model"
          className="inputCategoryVehicle"
        />
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
  );
};

export default FilterBar;
