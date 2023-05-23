import "./CatalogCard.scss";

const CatalogCard = () => {
  return (
    <div className="catalogCard">
      <div>
        <img src="./parts/tires.png" alt="" width={292} height={295} />
        <p>Tires</p>
        <span>price 165$</span>
      </div>
    </div>
  );
};

export default CatalogCard;
