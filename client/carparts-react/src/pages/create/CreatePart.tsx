import "./CreatePart.scss";

const CreatePart = () => {
  return (
    <div className="create">
      <div className="container">
        <h1>Add New Part</h1>
        <div className="sections">
          <div className="left">
            <label htmlFor="">Part Name</label>
            <input type="text" />
            <hr />
            <label htmlFor="">Part Description</label>
            <textarea name="" id="" cols={10} rows={10}></textarea>
            <hr />
            <label htmlFor="">Part Brand</label>
            <input type="text" />
            <hr />
            <label htmlFor="">Part Number</label>
            <input type="text" />
            <hr />
            <label htmlFor="">Manufacturer Number</label>
            <input type="text" />
            <hr />
            <label htmlFor="">Part Condition</label>
            <select name="" id="">
              <option value="">New</option>
              <option value="">Used</option>
            </select>
            <hr />
            <label htmlFor="">Part Material</label>
            <input type="text" />
            <hr />
            <label htmlFor="">Part Size</label>
            <input type="text" />
            <hr />
          </div>
          <div className="right">
            <div className="images">
              <div className="imagesInputs">
                <label htmlFor="">Cover Image</label>
                <input type="file" />
                <label htmlFor="">Upload Images</label>
                <input type="file" multiple />
              </div>
              <button>
                Upload
                {/* {uploading ? "uploading" : "upload"} */}
              </button>
            </div>
            <hr />
            <label htmlFor="">Category</label>
            <select name="" id="">
              <option value="">Cars</option>
              <option value="">Trucks</option>
              <option value="">Motorcycles</option>
            </select>
            <hr />
            <label htmlFor="">Part for Make </label>
            <select name="" id="">
              <option value="">Mercedes</option>
              <option value="">BMW</option>
              <option value="">Audi</option>
            </select>
            <hr />
            <label htmlFor="">Part for Model </label>
            <select name="" id="">
              <option value="">Q7</option>
              <option value="">X5</option>
              <option value="">C200</option>
            </select>
            <hr />
            <label htmlFor="">Price</label>
            <input type="text" />
            <hr />
          </div>
        </div>
      </div>
    </div>
  );
};

export default CreatePart;
