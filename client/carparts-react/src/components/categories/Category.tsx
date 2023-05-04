import "./Category.scss";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

const Category = () => {
  return (
    <div className="category">
        <h1>Categories</h1>
        <div className="subCategory">
          <a href="">NEW PRODUCTS</a>
          <a href="">FEATURED PRODUCTS</a>
          <a href="">BEST SELLERS</a>
        </div>
      <div className="container">
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>

          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
          <div className="item">
            <img src="./parts/tires.png" alt="img" className="part-pic" width={100} height={100}/>
            <span>Tires</span>
          </div>
      </div>
    </div>
  );
};

export default Category;
