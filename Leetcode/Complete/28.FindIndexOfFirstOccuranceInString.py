def strStr(self, haystack: str, needle: str) -> int:
    index = -1

    for idx, l in enumerate(haystack):
        if (l == needle[0]):
            for idx2, c in enumerate(needle, start=1):
                if c != haystack[idx2+idx]:
                    index = -1
                    break
                index = idx

    return index
