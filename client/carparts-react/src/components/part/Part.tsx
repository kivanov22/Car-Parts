import "./Part.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { useState } from "react";
import { faHeart, faEye } from "@fortawesome/free-solid-svg-icons";

const Part = () => {
  const [hovered, setHovered] = useState(false);

  const handleMouseOver = () => {
    setHovered(true);
  };

  const handleMouseLeave = () => {
    setHovered(false);
  };

  return (
    <div className="part">
      <div className="partType"></div>
      <div className="catalogParts">
        <ul>
          <li>
            <div className="partItem">
              <img
                src="./parts/tires.png"
                alt="part"
                width={292}
                height={295}
                onMouseOver={handleMouseOver}
                onMouseLeave={handleMouseLeave}
              />
              <p>Title</p>
              <p>59$</p>
              <p>Rating:</p>
              <button>Add to Cart</button>
              {hovered && (
                <div className="sideIcons">
                   <FontAwesomeIcon icon={faHeart} className="sideIconColor"/>
                  <FontAwesomeIcon icon={faEye} className="sideIconColor"/>
                </div>
              )}
            </div>
          </li>
          <li>
            <div className="partItem">
              <img
                src="./parts/tires.png"
                alt="part"
                width={292}
                height={295}
                onMouseOver={handleMouseOver}
                onMouseLeave={handleMouseLeave}
              />
              <p>Title</p>
              <p>59$</p>
              <p>Rating:</p>
              <button>Add to Cart</button>
              {hovered && (
                <div className="sideIcons">
                  <FontAwesomeIcon icon={faHeart} className="sideIconColor"/>
                  <FontAwesomeIcon icon={faEye} className="sideIconColor"/>
                </div>
              )}
            </div>
          </li>
          <li>
            <div className="partItem">
              <img
                src="./parts/tires.png"
                alt="part"
                width={292}
                height={295}
                onMouseOver={handleMouseOver}
                onMouseLeave={handleMouseLeave}
              />
              <p>Title</p>
              <p>59$</p>
              <p>Rating:</p>
              <button>Add to Cart</button>
              {hovered && (
                <div className="sideIcons">
                   <FontAwesomeIcon icon={faHeart} className="sideIconColor"/>
                  <FontAwesomeIcon icon={faEye} className="sideIconColor"/>
                </div>
              )}
            </div>
          </li>
        </ul>
      </div>
    </div>
  );
};

export default Part;
