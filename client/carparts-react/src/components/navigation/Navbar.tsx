import "./Navbar.scss";
import { Link } from "react-router-dom";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faShoppingCart,
  faHeart,
  faWarehouse,
  faUser,
} from "@fortawesome/free-solid-svg-icons";
import { useState } from "react";

const Navbar = () => {
  const[isOpen,setIsOpen] = useState(false);

  const handleOpen = ()=>{

    setIsOpen(!isOpen);
  }

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
        <button>Search</button>
      </div>
      <div className="right">
        {/* cart icon and total sum */}
        <div className="userIcons">
          <FontAwesomeIcon icon={faHeart} />
          <FontAwesomeIcon icon={faUser} onClick={handleOpen}/>
          {isOpen && 
          <div className="userModal">
            <p>Login</p>
            <p>Register</p>
          </div>
          }
          <FontAwesomeIcon icon={faWarehouse} />
        </div>
        <div className="shoppingCart">
          <FontAwesomeIcon icon={faShoppingCart} />
          <p>Items: 0</p>
          <p>Total: 25$</p>
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
