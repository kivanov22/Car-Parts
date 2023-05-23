import "./Navbar.scss";
import { Link } from "react-router-dom";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faShoppingCart,
  faHeart,
  faWarehouse,
  faUser,
  faSearch,
} from "@fortawesome/free-solid-svg-icons";
import { useState } from "react";

const Navbar = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [hovered, setHovered] = useState(false);

  const handleMouseOver = () => {
    setHovered(true);
  };

  const handleMouseLeave = () => {
    setHovered(false);
  };

  const handleOpen = () => {
    setIsOpen(!isOpen);
  };

  return (
    <div className="navbar">
      <div className="left">
        {/* logo */}
        <p className="firstText">
          Ivanov<span className="secondText">Parts</span>
        </p>
      </div>
      <div className="mid">
        <input type="text" placeholder="search for ..." />
        <button>
          <FontAwesomeIcon icon={faSearch} />
        </button>
      </div>
      <div className="right">
        {/* cart icon and total sum */}
        <div className="userIcons">
          <div className="favoritesContainer">
            <FontAwesomeIcon icon={faHeart} />
            <p>Favorites</p>
          </div>
          <div className="userContainer">
            <FontAwesomeIcon icon={faUser} onClick={handleOpen} />
            <p>Account</p>
            {isOpen && (
              <div className="userModal">
                <p>Login</p>
                <p>Register</p>
              </div>
            )}
          </div>
          <div className="myPartsContainer">
            <FontAwesomeIcon icon={faWarehouse} />
            <p>My Parts</p>
          </div>
        </div>
        <div
          className="shoppingCart"
          onMouseOver={handleMouseOver}
          onMouseLeave={handleMouseLeave}
        >
          <FontAwesomeIcon icon={faShoppingCart} />
          <p>Items: 0</p>
          <p>Total: 25$</p>
          {hovered && (
            <div className="cartModal">
              <p>5 Items</p>
            </div>
          )}
        </div>
        {/* favorites */}
        {/* my listings */}
        {/* sign in /logout */}
        {/* services page */}
      </div>
    </div>
  );
};

export default Navbar;
