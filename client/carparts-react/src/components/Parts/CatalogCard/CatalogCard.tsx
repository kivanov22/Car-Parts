import "./CatalogCard.scss";

const CatalogCard = () => {
  return (
    <div className="catalogCard">
      <div>
        <img src="./parts/tires.png" alt="" width={192} height={195} />
        <p>Tires</p>
        <span>price 165$</span>
        <p>Availability: In Stock</p>
      </div>
    </div>
  );
};

export default CatalogCard;
