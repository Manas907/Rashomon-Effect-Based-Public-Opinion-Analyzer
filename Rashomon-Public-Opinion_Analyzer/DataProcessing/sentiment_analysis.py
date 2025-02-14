from textblob import TextBlob

def analyze_sentiment(text):
    polarity = TextBlob(text).sentiment.polarity
    return "Positive" if polarity > 0 else "Negative" if polarity < 0 else "Neutral"

if __name__ == "__main__":
    sample_text = "This company is amazing!"
    print("Sentiment:", analyze_sentiment(sample_text))
