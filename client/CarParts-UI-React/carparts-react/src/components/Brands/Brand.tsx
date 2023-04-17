import React from "react";
import "./Brand.scss";

const Brand = () => {
  return (
    <div className="brand">
      <div>
        <h1>Famous manufacturer brands for parts.</h1>
      </div>
      <div className="brands">
        <div>
          <img src="./brands/bosch.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/hella.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/brembo.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/delphi.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/febi.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/sachs.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/textar.png" alt="img" className="brand" />
        </div>
        <div>
          <img src="./brands/beru.png" alt="img" className="brand" />
        </div>
      </div>
    </div>
  );
};

export default Brand;
