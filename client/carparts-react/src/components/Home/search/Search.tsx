import React from "react";
import "./Search.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faSearch } from "@fortawesome/free-solid-svg-icons";

const Search = () => {
  return (
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
        <option value="opel">Insignia</option>
        <option value="Audi">Q7</option>
        <option value="BMW">X5</option>
        <option value="Mercedes">C200</option>
      </select>
      <label htmlFor="specification">Specification</label>
      <select name="specification" id="specification">
        <option value="opel">C 200 Kompressor (2000-2005 year)</option>
        <option value="Audi">Audi</option>
        <option value="BMW">BMW</option>
        <option value="Mercedes">Mercedes</option>
      </select>
      <button>
        <FontAwesomeIcon icon={faSearch} />
        Search
      </button>
    </div>
  );
};

export default Search;
