import React from 'react'
import "./Search.scss"
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
  )
}

export default Search