import pandas as pd

def clean_reviews(input_file, output_file):
    df = pd.read_csv(input_file)
    df["clean_text"] = df["ReviewText"].str.lower().str.replace(r"[^a-zA-Z0-9 ]", "")
    df.to_csv(output_file, index=False)

if __name__ == "__main__":
    clean_reviews("raw_opinions.csv", "processed_opinions.csv")
